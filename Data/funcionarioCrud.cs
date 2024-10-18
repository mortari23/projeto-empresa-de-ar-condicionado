using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class funcionarioCrud
    {
        private readonly string _conexao;

        public funcionarioCrud(string conexao)
        {
            _conexao = conexao;
        }

        public void IncluirFuncionario(funcionario funcionario) 
        {
            const string query = @"INSERT INTO funcionario (nome_funcionario,telefone_funcionario,cpf_funcionario,endereco_funcionario,CEP_funcionario,bairro_funcionario,numero_funcionario,complemento_funcionario,cidade_funcionario)
                                 Values(@Nome_funcionario,@Telefone_funcionario,@CPF_funcionario,@Endereco_funcionario,@CEP_funcionario,@Bairro_funcionario,@numero_funcionario,@Complemento_funcionario,@Cidade_funcionario)";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comandoSql = new SqlCommand(query, conexaoBd))
                {
                    comandoSql.Parameters.AddWithValue("@Nome_funcionario", funcionario.nome_funcionario);
                    comandoSql.Parameters.AddWithValue("@Telefone_funcionario", funcionario.telefone_funcionario);
                    comandoSql.Parameters.AddWithValue("@CPF_funcionario", funcionario.cpf_funcionario);
                    comandoSql.Parameters.AddWithValue("@Endereco_funcionario", funcionario.endereco_funcionario);
                    comandoSql.Parameters.AddWithValue("@CEP_funcionario", funcionario.CEP_funcionario);
                    comandoSql.Parameters.AddWithValue("@Bairro_funcionario", funcionario.bairro_funcionario);
                    comandoSql.Parameters.AddWithValue("@Numero_funcionario", funcionario.numero_funcionario);
                    comandoSql.Parameters.AddWithValue("@Complemento_funcionario", funcionario.complemento_funcionario);
                    comandoSql.Parameters.AddWithValue("@Cidade_funcionario", funcionario.cidade_funcionario);

                    conexaoBd.Open();
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERROOOO !!!!!!!", ex);
            }
        }
        public DataSet BuscarFuncionario(string pesquisa = "")
        {
            const string query = "Select * From funcionario Where nome_funcionario Like @Pesquisa";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))

                using (var comando = new SqlCommand(query, conexaoBd))

                using (var adaptador = new SqlDataAdapter(comando))
                {
                    string parametroPesquisar = $"%{pesquisa}%";
                    comando.Parameters.AddWithValue("@Pesquisa", parametroPesquisar);

                    conexaoBd.Open();

                    var dsFuncionario = new DataSet();
                    adaptador.Fill(dsFuncionario, "funcionario");
                    return dsFuncionario;
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro em buscar Funcionario{ex.Message}", ex);
            }
        }
        public void ExcluirFuncionario(int codigofuncionario)
        {
            const string query = "DELETE FROM funcionario WHERE funcionarioID =@codigoFuncionario";
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@codigoFuncionario", codigofuncionario);
                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"ERRO ao deletar:{ex.Message}", ex);
            }
        }
        public void AlterarFuncionario(funcionario funcionario)
        {
            const string query = @"update funcionario set nome_funcionario = @Nome_funcionario, telefone_funcionario = @Telefone_funcionario, cpf_funcionario = @CPF_funcionario, endereco_funcionario = @Endereco_funcionario, cidade_funcionario = @Cidade_funcionario, CEP_funcionario = @CEP_funcionario, bairro_funcionario = @Bairro_funcionario, numero_funcionario = @Numero_funcionario where funcionarioID = @codigofuncionario";
             try
             {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comandoSql = new SqlCommand(query, conexaoBd))
                {
                    comandoSql.Parameters.AddWithValue("@Nome_funcionario", funcionario.nome_funcionario);
                    comandoSql.Parameters.AddWithValue("@Telefone_funcionario", funcionario.telefone_funcionario);
                    comandoSql.Parameters.AddWithValue("@CPF_funcionario", funcionario.cpf_funcionario);
                    comandoSql.Parameters.AddWithValue("@Endereco_funcionario", funcionario.endereco_funcionario);
                    comandoSql.Parameters.AddWithValue("@CEP_funcionario", funcionario.CEP_funcionario);
                    comandoSql.Parameters.AddWithValue("@Bairro_funcionario", funcionario.bairro_funcionario);
                    comandoSql.Parameters.AddWithValue("@Numero_funcionario", funcionario.numero_funcionario);
                    comandoSql.Parameters.AddWithValue("@Complemento_funcionario", funcionario.complemento_funcionario);
                    comandoSql.Parameters.AddWithValue("@Cidade_funcionario", funcionario.cidade_funcionario);
                    comandoSql.Parameters.AddWithValue("@codigofuncionario", funcionario.funcionarioID);

                    conexaoBd.Open();
                    comandoSql.ExecuteNonQuery();
                }
             }
            catch (Exception ex)
             {
                throw new Exception($"erro ao alterar o funcionario : {ex.Message}", ex);
             }
        }
        public funcionario ObtemFuncionario(int codigoFuncionario)
        {
            const string query = "SELECT * FROM funcionario WHERE funcionarioID =@cod";
            funcionario funcionario = null;

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@cod", codigoFuncionario);
                    conexaoBd.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            funcionario = new funcionario
                            {
                                funcionarioID = Convert.ToInt32(reader["funcionarioID"]),
                                nome_funcionario = reader["nome_funcionario"].ToString(),
                                telefone_funcionario = reader["telefone_funcionario"].ToString(),
                                cpf_funcionario = reader["cpf_funcionario"].ToString(),
                                endereco_funcionario = reader["cpf_funcionario"].ToString(),
                                CEP_funcionario = reader["CEP_funcionario"].ToString(),
                                bairro_funcionario = reader["bairro_funcionario"].ToString(),
                                numero_funcionario = reader["numero_funcionario"].ToString(),
                                complemento_funcionario = reader["complemento_funcionario"].ToString(),
                                cidade_funcionario = reader["cidade_funcionario"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return funcionario;
        }
    }
}
