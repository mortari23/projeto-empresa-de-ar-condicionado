using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class funcionarioCrud
    {
        private readonly string _conexao;

        public funcionarioCrud(string conexao)
        {
            _conexao = conexao;
        }

        public void IncluirFuncionario(funcionario funcionario) 
        {
            const string query = @"INSERT INTO funcionario (nome_funcionario,telefone_funcionario,cpf_funcionario,endereco_funcionario,gmail_funcionario,cidade_funcionario,CEP,bairro,numero_funcionario,compelemento_funcionario
                                 Values(@Nome_funcionario,@Telefone_funcionario,@CPF_funcionario,@Endereco_funcionario,@Gmail_funcionario,@Cidade_funcionario,@CEP,@Bairro,@numero_funcionario,@Compelemento_funcionario)";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comandoSql = new SqlCommand(query, conexaoBd))
                {
                    comandoSql.Parameters.AddWithValue("@Nome_funcionario", funcionario.nome_funcionario);
                    comandoSql.Parameters.AddWithValue("@Teleone_funcionario", funcionario.telfone_funcionario);
                    comandoSql.Parameters.AddWithValue("@CPF_funcionario", funcionario.cpf_funcionario);
                    comandoSql.Parameters.AddWithValue("@Endereco_funcionario", funcionario.endereco_funcionario);
                    comandoSql.Parameters.AddWithValue("@CEP", funcionario.CEP_funcionario);
                    comandoSql.Parameters.AddWithValue("@Bairro", funcionario.bairro_funcionario);
                    comandoSql.Parameters.AddWithValue("@Numero_funcionario", funcionario.numero_funcionario);
                    comandoSql.Parameters.AddWithValue("@Complemento_funcionario", funcionario.complemento_funcionario);

                    conexaoBd.Open();
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERROOOO !!!!!!!", ex);
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
            const string query = @"upate funcionario set" +
                                 "nome_funcionario =@Nome_funcionario" +
                                 "telefone_funcionario =@Telefone_funcionario" +
                                 "cpf_funcionario =@CPF_funcionario" +
                                 "endereco_funcionario =@Endereco_funcionario" +     
                                 "CEP =CEP" +
                                 "bairro =Bairro" +
                                 "numero_funcionario=@Numero_funcionario" +
                                 "complemento_funcionario=@Complemento_funcionario";
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comandoSql = new SqlCommand(query, conexaoBd))
                {
                    comandoSql.Parameters.AddWithValue("@Nome_cliente", funcionario.nome_funcionario);
                    comandoSql.Parameters.AddWithValue("@Teleone_cliente", funcionario.telfone_funcionario);
                    comandoSql.Parameters.AddWithValue("@CPF_cliente", funcionario.cpf_funcionario);
                    comandoSql.Parameters.AddWithValue("@Endereco_cliente", funcionario.endereco_funcionario);
                    comandoSql.Parameters.AddWithValue("@CEP", funcionario.CEP_funcionario);
                    comandoSql.Parameters.AddWithValue("@Bairro", funcionario.bairro_funcionario);
                    comandoSql.Parameters.AddWithValue("@Numero_casa", funcionario.numero_funcionario);
                    comandoSql.Parameters.AddWithValue("@Complemento_cliente", funcionario.complemento_funcionario);

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
                                telfone_funcionario = reader["telefone_funcionario"].ToString(),
                                cpf_funcionario = reader["cpf_funcionario"].ToString(),
                                endereco_funcionario = reader["cpf_funcionario"].ToString(),
                                CEP_funcionario = reader["CEP"].ToString(),
                                bairro_funcionario = reader["bairro"].ToString(),
                                numero_funcionario = reader["numero_funcionario"].ToString(),
                                complemento_funcionario = reader["complemento_funcionario"].ToString()
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
