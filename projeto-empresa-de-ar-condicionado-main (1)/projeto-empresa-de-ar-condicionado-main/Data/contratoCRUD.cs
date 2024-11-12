using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class contratoCRUD
    {
        private readonly string _conexao;
        public contratoCRUD(string conexao)
        {
            _conexao = conexao;
        }
        // Método para incluir um serviço no banco de dados
        public void IncluiContrato(contrato contrato)
        {
            const string query = @"INSERT INTO contrato (clienteID, descricao_contrato, valor_contrato, tipo_contrato, data_contrato, final_contrato)
                VALUES(@Clienteid, @Descricao_contrato, @Valor_contrato, @Tipo_contrato, @Data_contrato, @Final_contrato)";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comandoSql = new SqlCommand(query, conexaoBd))
                {
                    comandoSql.Parameters.AddWithValue("@Clienteid", contrato.clienteID.HasValue ? contrato.clienteID.Value : (object)DBNull.Value);
                    comandoSql.Parameters.AddWithValue("@Descricao_contrato", !string.IsNullOrEmpty(contrato.descricao_contrato) ? contrato.descricao_contrato : (object)DBNull.Value);
                    comandoSql.Parameters.AddWithValue("@Valor_contrato", contrato.valor_contrato.HasValue ? contrato.valor_contrato.Value : (object)DBNull.Value);
                    comandoSql.Parameters.AddWithValue("@Tipo_contrato", contrato.tipo_contrato ?? (object)DBNull.Value);
                    comandoSql.Parameters.AddWithValue("@Data_contrato", contrato.data_contrato.HasValue ? contrato.data_contrato.Value : (object)DBNull.Value);
                    comandoSql.Parameters.AddWithValue("@Final_contrato", contrato.final_contrato.HasValue ? contrato.final_contrato.Value : (object)DBNull.Value);
                    

                    conexaoBd.Open();
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao incluir contrato!", ex);
            }
        }
        public DataSet BuscarContrato(string pesquisa = "")
        {
            const string query = @"SELECT 
                ct.contratoID,
                c.nome_cliente AS nome_cliente,
                ct.descricao_contrato,
                ct.valor_contrato,
                ct.tipo_contrato,
                ct.final_contrato,
                ct.data_contrato
                FROM 
                contrato ct
               INNER JOIN 
               clientes c ON ct.clienteID = c.clienteID;";
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                using (var adaptador = new SqlDataAdapter(comando))
                {
                    string parametropesquisa = $"%{pesquisa}%";
                    comando.Parameters.AddWithValue("@pesquisa", parametropesquisa);
                    conexaoBd.Open();
                    var dsContrato = new DataSet();
                    adaptador.Fill(dsContrato, "contrato");
                    return dsContrato;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar o contrato: {ex.Message}", ex);
            }
        }
        // Método para excluir serviço
        public void ExcluirContrato(int codigoContrato)
        {
            const string query = "DELETE FROM contrato WHERE contratoID = @codigoContrato";
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@codigoContrato", codigoContrato);
                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir o contrato: {ex.Message}", ex);
            }
        }
        // Método para alterar serviço
        public void AlterarContrato(contrato contrato)
        {
           /* const string query = "UPDATE servico SET " +
                                 "ClienteID = @Clienteid, " +
                                 "descricao_contrato = @Descricao_contrato, " +
                                 "valor_contrato = @Valor_contrato, " +
                                 "tipo_contrato = @Tipo_contrato, " +
                                 "data_contrato = @Data_contrato, " +
                                 "final_contrato = @Final_contrato, " +
                                 "WHERE servicoID = @contratoID ";*/
            try
            {
                const string query = "UPDATE contrato SET " +
                                     "clienteID = @Clienteid, " +
                                     "descricao_contrato = @Descricao_contrato, " +
                                     "valor_contrato = @Valor_contrato, " +
                                     "tipo_contrato = @Tipo_contrato, " +
                                     "data_contrato = @Data_contrato, " +
                                     "final_contrato = @Final_contrato " +
                                     "WHERE contratoID = @contratoID";

                try
                {
                    using (var conexaoBd = new SqlConnection(_conexao))
                    using (var comandoSql = new SqlCommand(query, conexaoBd))
                    {
                        comandoSql.Parameters.AddWithValue("@Clienteid", contrato.clienteID.HasValue ? contrato.clienteID.Value : (object)DBNull.Value);
                        comandoSql.Parameters.AddWithValue("@Descricao_contrato", contrato.descricao_contrato ?? (object)DBNull.Value);
                        comandoSql.Parameters.AddWithValue("@Valor_contrato", contrato.valor_contrato.HasValue ? contrato.valor_contrato.Value : (object)DBNull.Value);
                        comandoSql.Parameters.AddWithValue("@Tipo_contrato", contrato.tipo_contrato ?? (object)DBNull.Value);
                        comandoSql.Parameters.AddWithValue("@Data_contrato", contrato.data_contrato.HasValue ? contrato.data_contrato.Value : (object)DBNull.Value);
                        comandoSql.Parameters.AddWithValue("@Final_contrato", contrato.final_contrato.HasValue ? contrato.final_contrato.Value : (object)DBNull.Value);
                        comandoSql.Parameters.AddWithValue("@contratoID", contrato.contratoID);

                        conexaoBd.Open();
                        comandoSql.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Erro ao alterar o contrato: {ex.Message}", ex);
                }
            }catch (Exception ex) 
            {
                throw new Exception($"Erro ao alterar o contrato: {ex.Message}", ex);
            }
        }
        // Método para obter um serviço
        public contrato ObtemContrato(int codigoContrato)
        {
            const string query = "SELECT * FROM contrato WHERE contratoID = @cod";
            contrato contrato = null;
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@cod", codigoContrato);
                    conexaoBd.Open();

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            contrato = new contrato
                            {
                                contratoID = reader["contratoID"] != DBNull.Value ? Convert.ToInt32(reader["contratoID"].ToString().Trim()) : 0,
                                clienteID = reader["clienteID"] != DBNull.Value ? Convert.ToInt32(reader["clienteID"].ToString().Trim()) : (int?)null,
                                data_contrato = reader["data_contrato"] != DBNull.Value ? DateTime.Parse(reader["data_contrato"].ToString().Trim()) : (DateTime?)null,                               
                                valor_contrato = reader["valor_contrato"] != DBNull.Value ? decimal.Parse(reader["valor_contrato"].ToString().Trim()) : (decimal?)null,                              
                                descricao_contrato = reader["descricao_contrato"] != DBNull.Value ? reader["descricao_contrato"].ToString().Trim() : null,                               
                                tipo_contrato = reader["tipo_contrato"] != DBNull.Value ? reader["tipo_contrato"].ToString().Trim() : null,
                                final_contrato = reader["final_contrato"] != DBNull.Value ? DateTime.Parse(reader["final_contrato"].ToString().Trim()) : (DateTime?)null,
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
                throw new Exception("Erro ao obter o contrato.", ex);
            }

            return contrato;
        }
    }

 }
