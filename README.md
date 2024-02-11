# Convert Image to Pdf App

Esta aplicação tem como objetivo converter imagens para PDF. Para este programa foi utilizado o package [QuestPDF]("https://www.questpdf.com/") para realizar a geração do arquivo PDF. Para o desenvolvimento da interface foi utilizado o [WPF]("https://learn.microsoft.com/pt-br/visualstudio/get-started/csharp/tutorial-wpf?view=vs-2022").


## Pré-requisitos

Antes de iniciar, verifique se você tem os seguintes requisitos:

<b>1 - Para rodar na máquina local</b>
- [SDK .NET 7.0]("https://dotnet.microsoft.com/pt-br/download/dotnet/7.0")

## Instalação

Para a instalação desse projeto temos 2 opções. Siga as etapas abaixo para configurar o projeto localmente:

<b>1 - Clonando Repositório</b>

1. Clone o repositório:

   ```shell
   git clone https://github.com/maatheux/convert-img-to-pdf-gui.git
   ```

2. Acesse o diretório do projeto:

    ```shell
    cd convert-img-to-pdf-gui
    ```

<b>2 - Realizando o download da pasta com o Executável</b>

1. Entre na pasta [convert-img-to-pdf.zip]("convert-img-to-pdf.zip")

2. Clique no botão de baixar

## Uso
Para executar o projeto localmente, siga as etapas abaixo:

<b>1 - Se clonou o repositório</b>

1. Dentro da pasta do projeto abra o terminal e digite o seguinte comando para realizar o build:

    ```shell
    dotnet build
    ```

2. Digite o seguinte comando para executar o projeto:

    ```shell
    dotnet run
    ```

<b>2 - Se realizou o download da pasta</b>

1. Extrai o arquivo zip

2. Execute o arquivo <i>ConvertImgToPdfApp.exe</i>


Com o programa rodando:

1. Insira o caminho da imagem (Ex: D:\caminho\imagem.png)

2. Insira o caminho de onde será salvo o arquivo PDF (Ex: D\caminho\arquivo.pdf)
