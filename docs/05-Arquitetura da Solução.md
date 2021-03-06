# Arquitetura da Solução

Apresentaremos a seguir os detalhes técnicos que tratam dos componentes que fazem parte da solução e do ambiente de hospedagem da solução, criado pela equipe. 

  

### Diagrama de Componentes 

Os componentes que fazem parte da solução são apresentados na Figura que se segue. 

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/PetCare/blob/main/docs/img/Arquitetura.jpeg)

Figura 4 - Arquitetura da Solução 

 

A solução implementada conta com os seguintes módulos:  

 

 - Navegador - Interface básica do sistema
	 - Páginas Web - Conjunto de arquivos HTML, CSS, JavaScript e imagens que implementam as funcionalidades do sistema.
 - Hospedagem - local na Internet onde as páginas são mantidas e acessadas pelo navegador.
	 - Plataforma Heroku ou Plataforma Netlify
 - Local Storage - armazenamento mantido no Navegador, onde são implementados através de uma biblioteca (JSON Server) o banco de dados baseados em JSON. São eles:
	 - Dados do usuário – informações do usuário como nome, e-mail, idade, cidade, estado e gênero.
	 - Dados do pet – informações do pet como nome, idade, peso, raça e cor.
	 - Dados de vacina – informações sobre as vacinas de caráter obrigatório, nome da vacina, data de aplicação, se necessita de dose reforço ou não, se necessitar de dose reforço data do retorno.
	 - Dados de medicamentos – nome do medicamento, quantidade a ser ministrado, periodicidade a ser ministrado, e receita em formato pdf, jpeg, png etc.
	  

### Hospedagem 

Como ambiente de hospedagem do site do nosso projeto utilizaremos a plataforma do Heroku ou Netlify. O site poderá ser acessado a partir do domínio posteriormente gerado pela plataforma nas próximas etapas. 
 
A publicação do site no Heroku ou no Netlify é feita por meio de uma submissão do projeto (push) via git para o repositório remoto que se encontrará no github.

## Diagrama de Classes

O Diagrama de Classes representa abstração dos objetos bem como os seus relacionamentos. Foram imaginados quatro objetos que representarão as principais entidades do sistema. 



![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/PetCare-/blob/main/docs/img/Diagrama%20de%20classes%20PetCare.PNG?raw=true)


## Modelo ER

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

![image](https://raw.githubusercontent.com/ICEI-PUC-Minas-PMV-ADS/PetCare-/main/docs/img/ER.png)
## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
 
![image](https://user-images.githubusercontent.com/78277341/162640286-5c5d21d3-f7ba-4f24-9b68-c5f1733094ce.png)

## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
