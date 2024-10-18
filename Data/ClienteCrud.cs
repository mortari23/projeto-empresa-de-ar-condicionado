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
    public class ClienteCRUD
    {
        private readonly string _conexao;

        public ClienteCRUD(string conexao)
        {
            _conexao = conexao;
        }

        public void IncluirCliente (Cliente cliente)
        {

            const string query = @"INSERT INTO clientes (nome_cliente,telefone_cliente,cpf_cliente,endereco_cliente,gmail_cliente,cidade_cliente,CEP_cliente,bairro_cliente,Numero_casa,complemento_cliente) Values (@Nome_cliente,@Telefone_cliente,@CPF_cliente,@Endereco_cliente,@Gmail_cliente,@Cidade_cliente,@CEP_cliente,@Bairro_cliente,@Numero_casa,@Complemento_cliente)";

            try
            {
                using (var conexaoBd = new SqlConnection (_conexao))
                using (var comandoSql =new SqlCommand(query, conexaoBd))
                {
                    comandoSql.Parameters.AddWithValue("@Nome_cliente", cliente.nome_cliente);
                    comandoSql.Parameters.AddWithValue("@Telefone_cliente", cliente.telefone_cliente) ;
                    comandoSql.Parameters.AddWithValue("@CPF_cliente", cliente.cpf_clienete);
                    comandoSql.Parameters.AddWithValue("@Endereco_cliente", cliente.endereco_cliente);
                    comandoSql.Parameters.AddWithValue("@Gmail_cliente", cliente.gmail_cliente);
                    comandoSql.Parameters.AddWithValue("@Cidade_cliente", cliente.cidade_cliente);
                    comandoSql.Parameters.AddWithValue("@CEP_cliente", cliente.CEP_cliente);
                    comandoSql.Parameters.AddWithValue("@Bairro_cliente", cliente.bairro_cliente);
                    comandoSql.Parameters.AddWithValue("@Numero_casa", cliente.numero_casa);
                    comandoSql.Parameters.AddWithValue("@Complemento_cliente", cliente.complemento_cliente);

                    conexaoBd.Open();
                    comandoSql.ExecuteNonQuery();
                }               
            }catch (Exception ex)
            {
                throw new Exception("ERROOOO !!!!!!!", ex);
            }
        }

        public DataSet BuscarCliente(string pesquisa = "")
        {
            const string query = "Select * From clientes Where nome_cliente Like @Pesquisa";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))

                using (var comando = new SqlCommand(query, conexaoBd))

                using (var adaptador = new SqlDataAdapter(comando))
                {
                    string parametroPesquisar = $"%{pesquisa}%";
                    comando.Parameters.AddWithValue("@Pesquisa", parametroPesquisar);

                    conexaoBd.Open();

                    var dsClientes = new DataSet();
                    adaptador.Fill(dsClientes, "clientes");
                    return dsClientes;
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro em buscar Clientes{ex.Message}", ex);
            }
        }



        public void ExcluirCliente (int codigocliente)
        {
            const string query = "DELETE FROM clientes WHERE clienteID =@codigoCliente";
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand (query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@codigoCliente", codigocliente);
                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                throw new  Exception ($"ERRO ao deletar:{ex.Message}",ex);
            }
        }
        public void AlterarCliente (Cliente cliente)
        { 
            const string query = @"update clientes set nome_cliente = @Nome_cliente,telefone_cliente = @Telefone_cliente, cpf_cliente = @CPF_cliente, endereco_cliente = @Endereco_cliente, gmail_cliente = @Gmail_cliente, cidade_cliente = @Cidade_cliente, CEP_cliente = @CEP_cliente, bairro_cliente = @Bairro_cliente, Numero_casa = @Numero_casa, complemento_cliente = @Complemento_cliente where clienteID = @codigoCliente";
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comandoSql = new SqlCommand(query, conexaoBd))
                {
                    comandoSql.Parameters.AddWithValue("@Nome_cliente", cliente.nome_cliente);
                    comandoSql.Parameters.AddWithValue("@Telefone_cliente", cliente.telefone_cliente);
                    comandoSql.Parameters.AddWithValue("@CPF_cliente", cliente.cpf_clienete);
                    comandoSql.Parameters.AddWithValue("@Endereco_cliente", cliente.endereco_cliente);
                    comandoSql.Parameters.AddWithValue("@Gmail_cliente", cliente.gmail_cliente);
                    comandoSql.Parameters.AddWithValue("@Cidade_cliente", cliente.cidade_cliente);
                    comandoSql.Parameters.AddWithValue("@CEP_cliente", cliente.CEP_cliente);
                    comandoSql.Parameters.AddWithValue("@Bairro_cliente", cliente.bairro_cliente);
                    comandoSql.Parameters.AddWithValue("@Numero_casa", cliente.numero_casa);
                    comandoSql.Parameters.AddWithValue("@Complemento_cliente", cliente.complemento_cliente);
                    comandoSql.Parameters.AddWithValue("@codigoCliente", cliente.clienteID);

                    conexaoBd.Open();
                    comandoSql.ExecuteNonQuery();
                }
            }catch (Exception ex)
            {
                throw new Exception($"erro ao alterar o cliente : {ex.Message}", ex);
            }
        }
        public Cliente ObtemCliente (int codigoCliente)
        {
            const string query = "SELECT * FROM clientes WHERE clienteID =@cod";
            Cliente cliente = null;

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@cod", codigoCliente);
                    conexaoBd.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new Cliente
                            {
                                clienteID = Convert.ToInt32(reader["clienteID"]),
                                nome_cliente = reader["nome_Cliente"].ToString(),
                                telefone_cliente = reader["telefone_cliente"].ToString(),
                                cpf_clienete = reader["cpf_cliente"].ToString(),
                                endereco_cliente = reader["endereco_cliente"].ToString(),
                                gmail_cliente = reader["gmail_cliente"].ToString(),
                                cidade_cliente = reader["cidade_cliente"].ToString(),
                                CEP_cliente = reader["CEP_cliente"].ToString(),
                                bairro_cliente = reader["bairro_cliente"].ToString(),
                                numero_casa = reader["numero_casa"].ToString(),
                                complemento_cliente = reader["complemento_cliente"].ToString()
                            };
                        }                       
                    }
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message,ex);
            }
            return cliente;
        }   
    }
}
