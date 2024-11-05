using System;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class ServicoCrud
    {
        private readonly string _conexao;
        public ServicoCrud(string conexao)
        {
            _conexao = conexao;
        }

        // Método para incluir um serviço no banco de dados
        public void IncluiServico(servico servico)
        {
            const string query = @"INSERT INTO servico (clienteID, data_servico, valor_servico, descricao_serviço, funcionarioID)
                VALUES(@Clienteid, @Data_servico, @Valor_servico, @Descricao_servico,  @Funcionarioid)";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comandoSql = new SqlCommand(query, conexaoBd))
                {
                    comandoSql.Parameters.AddWithValue("@Clienteid", servico.clienteID.HasValue ? servico.clienteID.Value : (object)DBNull.Value);
                    comandoSql.Parameters.AddWithValue("@Data_servico", servico.data_servico.HasValue ? servico.data_servico.Value : (object)DBNull.Value);
                    comandoSql.Parameters.AddWithValue("@Valor_servico", servico.valor_servico.HasValue ? servico.valor_servico.Value : (object)DBNull.Value);
                    comandoSql.Parameters.AddWithValue("@Descricao_servico", !string.IsNullOrEmpty(servico.descricao_servico) ? servico.descricao_servico : (object)DBNull.Value);                  
                    comandoSql.Parameters.AddWithValue("@Funcionarioid", servico.funcionarioID.HasValue ? servico.funcionarioID.Value : (object)DBNull.Value);

                    conexaoBd.Open();
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao incluir serviço!", ex);
            }
        }

       



        // Método para buscar serviços
        public DataSet BuscarServico(string pesquisa = "")
        {
            const string query = "SELECT * FROM servico WHERE servicoID LIKE @Pesquisa";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                using (var adaptador = new SqlDataAdapter(comando))
                {
                    string parametropesquisa = $"%{pesquisa}%";
                    comando.Parameters.AddWithValue("@pesquisa", parametropesquisa);
                    conexaoBd.Open();
                    var dsServico = new DataSet();
                    adaptador.Fill(dsServico, "servico");
                    return dsServico;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar o serviço: {ex.Message}", ex);
            }
        }

        // Método para excluir serviço
        public void ExcluirServico(int codigoServico)
        {
            const string query = "DELETE FROM servico WHERE servicoID = @codigoServico";
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@codigoServico", codigoServico);
                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir o serviço: {ex.Message}", ex);
            }
        }

        // Método para alterar serviço
        public void AlterarServico(servico servico)
        {
            const string query = "UPDATE servico SET " +
                                 "ClienteID = @Clienteid, " +
                                 "FuncionarioID = @Funcionarioid, " +
                                 "data_servico = @Data_servico, " +
                                 "valor_servico = @Valor_servico, " +
                                 "descricao_servico = @Descricao_servico, " +
                                 "WHERE servicoID = @servicoID"; 
                                

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comandoSql = new SqlCommand(query, conexaoBd))
                {
                    comandoSql.Parameters.AddWithValue("@Clienteid", servico.clienteID);
                    comandoSql.Parameters.AddWithValue("@Funcionarioid", servico.funcionarioID);
                    comandoSql.Parameters.AddWithValue("@Data_servico", servico.data_servico);
                    comandoSql.Parameters.AddWithValue("@Valor_servico", servico.valor_servico);
                    comandoSql.Parameters.AddWithValue("@Descricao_servico", servico.descricao_servico);                  
                    comandoSql.Parameters.AddWithValue("@servicoID", servico.servicoID);

                    conexaoBd.Open();
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao alterar o serviço: {ex.Message}", ex);
            }
        }

        // Método para obter um serviço
        public servico ObtemServico(int codigoServico)
        {
            const string query = "SELECT * FROM servico WHERE servicoID = @cod";
            servico servico = null;

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@cod", codigoServico);
                    conexaoBd.Open();

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            servico = new servico
                            {
                                servicoID = reader["servicoID"] != DBNull.Value ? Convert.ToInt32(reader["servicoID"].ToString().Trim()) : 0,
                                funcionarioID = reader["FuncionarioID"] != DBNull.Value ? Convert.ToInt32(reader["FuncionarioID"].ToString().Trim()) : (int?)null,
                                clienteID = reader["clienteID"] != DBNull.Value ? Convert.ToInt32(reader["clienteID"].ToString().Trim()) : (int?)null,
                                
                                data_servico = reader["data_servico"] != DBNull.Value ? DateTime.Parse(reader["data_servico"].ToString().Trim()) : (DateTime?)null,
                               
                                valor_servico = reader["valor_servico"] != DBNull.Value ? decimal.Parse(reader["valor_servico"].ToString().Trim()) : (decimal?)null,
                               
                                descricao_servico = reader["descricao_servico"] != DBNull.Value ? reader["descricao_servico"].ToString().Trim() : null,
                               
                            };
                        }
                    }
                }
            }
            catch (FormatException fe)
            {
                throw new FormatException("Erro ao converter um valor do banco de dados. Verifique o formato dos dados.", fe);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o serviço.", ex);
            }

            return servico;
        }


    }
}
