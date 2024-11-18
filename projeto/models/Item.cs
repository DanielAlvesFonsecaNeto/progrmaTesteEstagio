class Item{


    public int Id_item {get;set;}

    public int Id_nota {get;set;}

    public string Produto {get;set;}
    public float Valor {get;set;}
    public float Tamanho {get;set;}

    // tem um relacionamento N pra 1 com NotaFiscal
    public NotaFiscal NotaFiscal {get;set;}

}

