using System;
using services;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo!");

         try
        {
            var conexao = ConexaoBD.Instancia.ObterConexao();
            Console.WriteLine("Conexão com o banco de dados foi bem-sucedida!");
            Console.WriteLine($"Estado da conexão: {conexao.State}");
            ConexaoBD.Instancia.FecharConexao();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
        }


        
    }
}
