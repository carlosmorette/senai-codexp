using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace Exercício_1 {
    class Program {
        static void Main (string[] args) {
            #region 
            Document exercício_1 = new Document ();
            #endregion

            #region Criacao da primeira secao no Documento 1
            Section parte1 = exercício_1.AddSection ();
            #endregion

            //1.1Criando um título
            #region Criar um titulo
            Paragraph titulo = parte1.AddParagraph ();
            #endregion

            //1.1 Atribuindo texto ao titulo
            #region Adicionar um texto ao titulo
            titulo.AppendText ("Informação\n\n");
            #endregion

            //1.1 Título
            #region Formatar paragrafo
            //Alinhando titulo no Centro (centralizado)
            titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;
            #endregion
            //1.1 Titulo finalizado

            //1.2 Criando um Parágrago
            #region Criando um Parágrafo
            Paragraph p1 = parte1.AddParagraph ();
            #endregion

            //1.2 Adicionando texto ao parágrafo
            #region Adicionando texto ao paragrafo
            p1.AppendText ("O pinguim é uma ave da família Spheniscidae, característica do hemisfério sul, em especial na Antártida e ilhas dos mares austrais, chegado à Terra do Fogo, Ilhas Malvinas e África do Sul, entre outros.\n\n");
            #endregion

            //1.2 Formatando o texto com várias estilizações
            #region Formatando paragrafo

            //1.2 Centro
            p1.Format.HorizontalAlignment = HorizontalAlignment.Center;

            ParagraphStyle estiloparagrafo = new ParagraphStyle (exercício_1);

            estiloparagrafo.Name = "Estilo parágrafo";

            //1.2 Color Red
            estiloparagrafo.CharacterFormat.TextColor = Color.DarkGreen;

            //1.2 Bold
            estiloparagrafo.CharacterFormat.Bold = true;

            exercício_1.Styles.Add(estiloparagrafo);

            p1.ApplyStyle (estiloparagrafo.Name); 
            // 1.2 Não esquecer de colocar Name para puxar o estilo
            #endregion
            //1.2 Paragrafo Finalizado

            //1.3 - 4 Columns x 3 Linhas - Listando Marmitas Gourmet
            #region Tabela 
            //Adicionando uma tabela à secao Atual (Lembrando que Section é uma nova folha(pagina))
            Table tabela = parte1.AddTable (true);

            //1.3 Cabeçalho
            String[] cabecalho = { "Nome", "Descrição", "Nome Vendedor", "Preço" };

            //Cria os dados da tabela
            String[][] dados = {
                new String[] { "Molho Madeira", "Carne, Arroz e Legumes", "Alberto", "R$ 20,00" },
                new String[] { "Carne com Queijo", "Carne com molho e Quiejo Mussarela", "Larissa", "R$ 25,00" },
                new String[] { "Feijão Batata", "Feijão branco com Batata", "Yuri", "R$ 10,00" },
            };

            //1.3 Adiciona células na tabela
            tabela.ResetCells (dados.Length + 1, cabecalho.Length);

            //1.3 Adiciona uma linha na posição 0
            //Também define que esta linha é o cabeçalho
            TableRow Linha1 = tabela.Rows[0];
            Linha1.IsHeader = true;

            //1.3 Definindo altura da Linha
            Linha1.Height = 20;

            //Cor de fundo da Linha1 que é o cabeçalho
            Linha1.RowFormat.BackColor = Color.White;

            //Percorre as colunas do cabeçalho devido a deixar todos as células do cabeçalho com esta formatação
            for (int c = 0; c < cabecalho.Length; c++) {
                //Alinhamento das células
                Paragraph par = Linha1.Cells[c].AddParagraph ();
                Linha1.Cells[c].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                par.Format.HorizontalAlignment = HorizontalAlignment.Center;

                //Intervalo de Texto - tratando o cabeçalho
                TextRange TR = par.AppendText (cabecalho[c]);
                TR.CharacterFormat.FontName = "Arial"; //Colocando Fonte Arial
                TR.CharacterFormat.FontSize = 12; //Definindo o tamanho de 12
                TR.CharacterFormat.TextColor = Color.Blue; //Definindo cor da letra
                TR.CharacterFormat.Italic = true; //Deixando a cor em italico
            }

            for (int g = 0; g < dados.Length; g++) {
                //Dizendo que LinhaDados corresponde as linhas de dados da tabela
                TableRow LinhaDados = tabela.Rows[g + 1];

                LinhaDados.Height = 40;

                for (int q = 0; q < dados[g].Length; q++) {

                    //Alinhando o conteúdo no Meio (Middle)
                    LinhaDados.Cells[q].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                    Paragraph p2 = LinhaDados.Cells[q].AddParagraph ();

                    TextRange TR2 = p2.AppendText (dados[g][q]);

                    //Formatação das Células
                    p2.Format.HorizontalAlignment = HorizontalAlignment.Center;
                    TR2.CharacterFormat.FontName = "Arial";
                    TR2.CharacterFormat.FontSize = 10;
                    TR2.CharacterFormat.TextColor = Color.Black;
                }
            }
            #endregion

            //2.1  2.2  2.3            
            #region  Criacao da segunda secao no Documento 1
            Section parte2 = exercício_1.AddSection ();

            #endregion

            //2.1
            #region Inserindo uma imagem centralizada
            Paragraph imagem = parte2.AddParagraph ();

            imagem.Format.HorizontalAlignment = HorizontalAlignment.Center;

            DocPicture imagemEx = imagem.AppendPicture (Image.FromFile (@"saida\img\pinguins.jpeg"));

            imagemEx.Width = 300;
            imagemEx.Height = 300;

            #endregion

            //2.2
            #region Descrição da imagem
            Paragraph DescriIma = parte2.AddParagraph ();
            #endregion

            #region Conteúdo Descrição
            DescriIma.AppendText ("Pinguins felizes dançando");
            #endregion

            #region Salvar arquivo
                exercício_1.SaveToFile (@"saida\exercicio.pdf", FileFormat.PDF);
            #endregion

        }
    }
}