# Bravely_Default_Text_Injector

## Conceito do projeto
### A aplicação permite Injetar os textos modificados e filtrar os ponteiros dos arquivos do jogo Bravely 
O programa feito permite criar um arquivo binário em codificação UTF-16 com os textos fornecidos pelo usuário (tendo o texto \n em seu formato ou não) para serem inseridos no jogo Bravely Default do console Nintendo 3ds,dessa forma,permitindo que a tradução do jogo de Inglês para Português Brasileiro seja feita de forma automatizada durante a fase de Romhacking do jogo. Também está incluso uma função de filtragem de ponteiros corrompidos(ponteiros que são desnecessários para o jogo rodar normalmente), dessa forma, é possível otimizar o processo de tradução com o aplicativo Kruptar7 -  

## Pré-requisitos e recursos utilizados
Programa feito em C# com a Biblioteca Komponent (Para fins de uso do comando BinaryWriter customizado) do programa Kuriimu2.<br/>
Source do Kuriimu2 com a biblioteca usada: https://github.com/FanTranslatorsInternational/Kuriimu2 <br/><br/>
Além disso, foi utilizado as bibliotecas padrões do Windows Forms, permitindo fazer uma interface para o projeto.<br>
Para Debug do programa, foi criado a exibição de um Console para que o usuário possa verificar o que está ocorrendo com o programa em tempo real, sendo mais simples de localizar erros em arquivos, caso haja.
  
## Passo a passo

1. Extraí a RomFS do jogo Brvaely Default e descompactei os arquivos Crowd.fs e Index.fs originais para que fosse gerado os sub-arquivos do projeto
2. Estudei a estrutura de ponteiros e textos dos arquivos do jogo para realizar a extração usando o aplicativo russo Kruptar7 - http://magicteam.net/?page=programs&show=Kruptar%207
3. Criei projetos em extensões .kpx dentro do Kruptar7 a partir da engenharia reversa dos ponteiros do jogo para poder extrair e injetar os textos com arquivos .txt
4. Implementei uma função com o objetivo de injetar os textos traduzidos, convertendo do formato UTF-8 para UNICODE (Codificação de texto aceito pelos arquivos do Bravely Default) 
5. Implementei uma função com o objetivo de filtrar os ponteiros corrompidos dos arquivos de texto do jogo, dessa forma, o processo de tradução é otimizado, juntamente com o carregamento dos futuros patchs, visto que os arquivos serão mais leves utilizando o filtro.
6. Criei uma interface gráfica para utilizar o programa de comunicação de forma mais intuitiva, adicionando um menu de Ajuda com tutoriais para utilizar o programa e abas de referência ao repositório do código e meu perfil no Github.

## Imagens/screenshots

![Imagem](https://github.com/MrVtR/Bravely_Default_Text_Injector/blob/master/Imagens/Interface.PNG)

---
![Imagem](https://github.com/MrVtR/Bravely_Default_Text_Injector/blob/master/Imagens/Kruptar.PNG)

---
![Imagem](https://github.com/MrVtR/Bravely_Default_Text_Injector/blob/master/Imagens/textFuntion.PNG)

---

![Imagem](https://github.com/MrVtR/Bravely_Default_Text_Injector/blob/master/Imagens/textFuntion.PNG)



