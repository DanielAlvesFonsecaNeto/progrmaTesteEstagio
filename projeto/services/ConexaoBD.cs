using System;
using System.Data;
using Npgsql;

namespace services
{
    //classe singleton de conexao com banco de dados
    public class ConexaoBD
    {
        //
        private static ConexaoBD _instancia;
        private NpgsqlConnection _conexao;

        private ConexaoBD(){

            string conexaoString = @"
            Host=localhost;
            Port=5432;
            Username=postgres;
            Password=123;
            Database=teste_estagio";

            _conexao = new NpgsqlConnection(conexaoString);

        }

        public static ConexaoBD Instancia{
            get{
                if(_instancia == null){
                    _instancia = new ConexaoBD();
                }
                return _instancia;
            }
        }

        public NpgsqlConnection ObterConexao(){
            if(_conexao.State != ConnectionState.Open){
                _conexao.Open();
            }
            return _conexao;
        }

        public void FecharConexao(){
            if(_conexao.State == ConnectionState.Open){
                _conexao.Close();
            }
        }

    }
}

/*
    a npgsql implementa a System.data, só que valor como do enum Connection.Open é da system.data e não tem na npgsql
*/