Livro livro1 = new Livro();
livro1.titulo = "SPQR";
livro1.autor = "Mary Beard";
livro1.ano = 2015;
livro1.paginas = 568;

livro1.informacoes();

if (livro1.TemMaisDe300Paginas())
{
    Console.WriteLine("O livro tem mais de 300 páginas");
}
else{
    Console.WriteLine("O livro tem menos de 300 páginas");
}
