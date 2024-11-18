class NotaFiscal{

    public int Id_nota {get;set;}

    public string Emissor {get;set;}
    public DateTime Data {get;set;}

    //relacionamento 1 pra N com a tabela item, uma nota fiscal pode estar relacionada com muitos itens
    // poderia usar ICollection<Item>
    public ICollection<Item> Itens {get;set;}


    public NotaFiscal(){

    }

}

