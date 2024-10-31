using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ServicoCrud
    {
        private readonly string _conexao;
        public ServicoCrud (string conexao)
        {
            _conexao = conexao;
        }
        //metodo incluir servico, recebe o objeto cliente da tela cliente
        //inclui no bnaco de dados
        public void IncluiServico(servico servico)
        {
            //query para inserir algo com SQL no banco de dados 
            const string query = @"INSERT INTO servico (clienteID,funcionarioID,data_servico,valor_servico,descricao_servico,descricao_contrato,valor_contrato,tipo_contrato,data_contrato)
                Values(@Clienteid,@Funcionarioid,@Data_servico,@Valor_servico,@Descricao_servico,@Descricao_contrato,@Valor_contrato,@Tipo_contrato,@Data_contrato)";

            //bloco para tratar possiveis erros ao inserir e exebir mensagens
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
                    comandoSql.Parameters.AddWithValue("@Descricao_contrato", servico.descricao_contrato);
                    comandoSql.Parameters.AddWithValue("@Valor_contrato", servico.valor_contrato);
                    comandoSql.Parameters.AddWithValue("@Tipo_contrato", servico.tipo_contrato);
                    comandoSql.Parameters.AddWithValue("@Data_contrato", servico.data_contrato);

                    conexaoBd.Open();

                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO ao incluir servico!!!!!", ex);
            }
        }
        //buscar servico fazer a busca no banco de dados
        public DataSet BuscarServico(string pesquisa = "")
        {
            const string query = "Select * from servico Where servicoID Like @Pesquisa";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query,conexaoBd))
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
                throw new Exception($"Erro ao buscar o servico {ex.Message}",ex);
            }
        }

        //excluir Servico
        public void ExcluirServico (int codigoServico)
        {
            //quer SQL excluir cliente
            const string query = "DELETE FROM servico Where servicoID = @codigoServico";
            try
            {
                //criando uma conexao com o bd
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue(@"codigoServico", codigoServico);
                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro ao deletar o servico : {ex.Message}",ex);
            }
        }

        //alterar cliente
        public void AlterarServico(servico servico)
        {
            const string query = "@update servico set " +
                                 "ClienteID = @Clienteid," +
                                 "FuncionarioID = @Funcionarioid," +
                                 "data_servico = @Data_servico," +
                                 "valor_servico = @Valor_servico," +
                                 "descricao_servico = @Descricao_servico," +
                                 "descricao_contrato = @Descricao_contrato," +
                                 "valor_contrato = @Valor_contrato" +
                                 "tipo_contrato = @Tipo_contrato" +
                                 "data_contrato = @Data_contrato"+                          
                                 "where servicoID = @codigoServico";
                                 
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comandoSql = new SqlCommand (query, conexaoBd))
                {
                    comandoSql.Parameters.AddWithValue("@Clienteid", servico.clienteID);
                    comandoSql.Parameters.AddWithValue("@Funcionarioid", servico.funcionarioID);
                    comandoSql.Parameters.AddWithValue("@Data_servico", servico.data_servico);
                    comandoSql.Parameters.AddWithValue("@Valor_servico", servico.valor_servico);
                    comandoSql.Parameters.AddWithValue("@Descricao_servico", servico.descricao_servico);
                    comandoSql.Parameters.AddWithValue("@Descricao_contrato", servico.descricao_contrato);
                    comandoSql.Parameters.AddWithValue("@Valor_contrato", servico.valor_contrato);
                    comandoSql.Parameters.AddWithValue("@Tipo_contrato", servico.tipo_contrato);
                    comandoSql.Parameters.AddWithValue("@Data_contrato", servico.data_contrato);




                    conexaoBd.Open();

                    comandoSql.ExecuteNonQuery ();
                }
            }
            catch (Exception ex)
            {
                throw new Exception ($"Erro ao alterar o servico : {ex.Message}",ex);
            }
        }
        public void ObtemServico (int codigoServico)
        {
            const string query = "Select * from servico Where  servicoID = @codigoServico";
                
            servico servico = null; //variavel para armazenar o cliente
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@codigoServico", codigoServico );
                    conexaoBd.Open();

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            servico = new servico
                            {
                                servicoID = Convert.ToInt32(reader["servicoID"]),

                                clienteID = Convert.ToInt32(reader["clienteID"]),

                                funcionarioID = Convert.ToInt32(reader["funcionarioID"]),
                                //----------------------------------------------------//

                                data_servico =Convert.ToDateTime( reader["data_servico"]),

                                valor_servico = Convert.ToDecimal(reader["valor_servico"]),

                                descricao_servico = reader["descricao_servico"].ToString(),

                                descricao_contrato = reader["descricao_contrato"].ToString(),

                                valor_contrato = Convert.ToDecimal(reader["valor_contrato"]),

                                tipo_contrato = reader["tipo_contrato"].ToString(),

                                data_contrato = Convert.ToDateTime(reader["data_contrato"]),
                            };

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            } 
              
        }
        
    }
}
