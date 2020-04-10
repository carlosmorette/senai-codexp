using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace Exemplo {
    class Program {
        static void Main (string[] args) {
            #region 
                Document exemploDoc = new Document ();
            #endregion

            #region Criacao de secao no documento
                //Adiciona uma seção com o nome secaoCapa ao documento
                //Cada secao pode ser entndido como uma pagina do documento
                Section secaoCapa = exemploDoc.AddSection ();
            #endregion

            #region Criar um paragrafo
                //Cria um paragrafo com o nome título e adiciona à seção secaoCapa
                //Os parágrafos são necessários para inserção de textos, imagens, tabelas etc
                Paragraph titulo = secaoCapa.AddParagraph ();
            #endregion

            #region Adiciona texto ao parágrafo
                //Adiciona o texto Exemplo de título ao parágrafo título
                titulo.AppendText ("Exemplo de título\n\n");
            #endregion

            #region Formatar paragrafo
                //Através da propriedade HorizontalAligment, é posspivel alinhar o parágrafo
                titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;

                //Cria um estilo com o nome estilo01 e adiciona ao documento
                ParagraphStyle estilo01 = new ParagraphStyle (exemploDoc);

                //Adiciona um nome ao estilo01
                estilo01.Name = "Cor do título";

                //Definir a cor do título
                estilo01.CharacterFormat.TextColor = Color.DarkGreen;

                //Define que o texto será em negrito
                estilo01.CharacterFormat.Bold = true;

                //Adiciona o estilo01 ao documento exemploDoc
                exemploDoc.Styles.Add (estilo01);

                //Aplica o estilo01 ao parágrafo título
                titulo.ApplyStyle (estilo01.Name);
            #endregion

            #region Trabalhar com tabulação
                //Adiciona um paragrafo textoCapa à seção secaoCapa
                Paragraph textoCapa = secaoCapa.AddParagraph ();

                //Adiciona um texto ao parágrafo com tabulação
                textoCapa.AppendText ("\t Este é um exemplo de texto com tabulação\n");

                //Adiciona um novo parágrafo à mesma seção (secaoCaoa)
                Paragraph textoCapa2 = secaoCapa.AddParagraph ();

                //Adiciona um texto ao parágrafo textoCapa2 com concatenação
                textoCapa2.AppendText ("\tBasicamente, então, uma seção representa uma página do documento e os parágrafos dentro de uma mesma seção" + "obviamente, aparecem na mesma página");
            #endregion

            #region Inserir imagens
                //Adiciona um parágrafo à seção capa    
                Paragraph imagemCapa = secaoCapa.AddParagraph();
                
                //Adiciona um texto ao parágrafo imagemCapa
                imagemCapa.AppendText("\n\n\tAgora vamos inserir uma imagem ao documento\n\n");

                //Centraliza horizontalmente o parágrafo imagemCapa
                imagemCapa.Format.HorizontalAlignment = HorizontalAlignment.Center;

                //Adiciona uma imagem com o nome imagemExemplo ao parágrafo imagemCapa
                DocPicture imagemExemplo = imagemCapa.AppendPicture(Image.FromFile(@"saida\img\logo_csharp.png"));

                //Define a largura e a altura da imagem
                imagemExemplo.Width = 300;
                imagemExemplo.Height = 300;
            #endregion

            #region Adicionar nova seção
                //Adiciona uma nova seção
                Section secaoCorpo = exemploDoc.AddSection();

                //Adiciona um novo parágrafo a esta nova seção
                Paragraph paragrafoCorpo1 = secaoCorpo.AddParagraph();

                //Adicionam um texto a este paragrafo paragrafoCorpo1
                paragrafoCorpo1.AppendText("\nEste é um exemplo de criação de um parágrafo em uma nova página, após uma quebra de seção."+ "Assim como quando utilizamos variáveis, é possível fechar aspas, inserir um sino '+' e continuar o parágrafo.\n\n"+"\tComo foi criada outra seção, perceba que o parágrafo acima começou em outra página.\n");

            #endregion

            #region Adicionar uma tabela
                //Adiciona uma tabela à seção secaoCorpo
                Table tabela = secaoCorpo.AddTable(true);

                //Cria o cabeçalho da tabela
                String[] cabecalho = {"Item","Descrição","Qtd","Preço Unit.","Preço"};

                //Cria os dados da tabela
                String[][] dados = {
                    new String[]{"Cenoura","Vegetal muito nutritivo","1","R$ 4,00","R$ 4,00"},
                    new String[]{"Batata","Vegetal muito consumido","2","R$ 5,00","R$ 10,00"},
                    new String[]{"Alface","Vegetal utilizado desde 500a.c","1","R$ 1,50","R$ 1,50"},
                    new String[]{"Tomate","Tomate é uma fruta","2","R$ 6,00","R$ 12,00"},
                };
                
                //Adiciona as células na tabela
                tabela.ResetCells(dados.Length + 1 , cabecalho.Length);

                //Adiciona uma linha na posição [0] no vetor de linhas
                //E define que esta linha é o cabeçalho
                TableRow Linha1 = tabela.Rows[0];
                Linha1.IsHeader = true;

                //Define a altura da linha
                Linha1.Height = 23;

                //Formação do cabeçalho
                Linha1.RowFormat.BackColor = Color.AliceBlue;

                //Percorre as colunas do cabeçalho
                for (int i = 0; i < cabecalho.Length ; i++){

                    //Alinhamento das células
                    Paragraph p = Linha1.Cells[i].AddParagraph();
                    Linha1.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = HorizontalAlignment.Center;

                    //Formatação dos dados do cabeçalho
                    TextRange TR = p.AppendText(cabecalho[i]);
                    TR.CharacterFormat.FontName = "Calibri";
                    TR.CharacterFormat.FontSize = 14;
                    TR.CharacterFormat.TextColor = Color.Teal;
                    TR.CharacterFormat.Bold = true;
                }

                //Adiciona as linhas do corpo da tabela
                for (int r = 0; r < dados.Length; r++){
                    TableRow LinhaDados = tabela.Rows[r + 1];

                    //Define a altura da linha
                    LinhaDados.Height = 20;

                    for (int c = 0; c < dados[r].Length; c++){
                        //Alinha as células
                        LinhaDados.Cells[c].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                        //Preencher os dados nas linhas
                        Paragraph p2 = LinhaDados.Cells[c].AddParagraph();

                        TextRange TR2 = p2.AppendText(dados[r][c]);
                    
                        //Formata as células
                        p2.Format.HorizontalAlignment = HorizontalAlignment.Center;
                        TR2.CharacterFormat.FontName = "Calibri";
                        TR2.CharacterFormat.FontSize = 12;
                        TR2.CharacterFormat.TextColor = Color.Brown;
                    }
                }
            #endregion

            #region Salvar arquivo
                // Salva o arquivo em .Docx
                //Utiliza o método SaveToFile para salvar o arquivo no formato desejado
                //Assim como no Word, caso já exista um arquivo com este nome, é substituído
                exemploDoc.SaveToFile(@"saida\exemplo_arquivo_word.docx",FileFormat.Docx);
            #endregion

        }
    }
}