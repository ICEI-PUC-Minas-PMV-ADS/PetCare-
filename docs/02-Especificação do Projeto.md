# Especificações do Projeto



A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foram consolidados com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.  

## Personas

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foram consolidados com a participação dos usuários em um trabalho de imersão feito pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.  

Desta forma, constatou-se que o presente projeto possui 3 principais personas: 

- Jovens, universitários (na faixa de idade entre 18 e 39 anos).
- Adultos: pais e mães com filhos menores, que possuem um ou alguns animais domésticos (na faixa de idade entre 40 e 59 anos ).
- Idosos/aposentados/competidores: criam um ou muitos animais, não só para companhia/afeto, mas também por motivos econômicos (ainda que em caráter doméstico), altruísta, segurança ou de status social, seja em associações de apoio animal, competições municipais ou pequenas glebas rurais particulares (faixa de idade acima de 60 anos de idade). 

A seguir, passamos à análise detalhada das principais personas e suas respectivas histórias de usuários. 

## Personas

| Pedro Góis        |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|![](https://user-images.githubusercontent.com/78277341/158038149-d6b7dd9c-bff0-439c-9b96-233542235633.png)|**Idade:** 27  anos - **Ocupação:** Desenhista industrial  |Aplicativos: Instagram, Facebook, Linkedin, Aplicativos de bancos.|
|**Motivações:**  Pedro possui um filhote de pastor alemão, de 5 meses de idade. Ele é sua principal companhia em casa. |**Frustrações:** Pedro é universitário e trabalha de dia e estuda à noite. Possui muitas responsabilidades e precisa otimizar os cuidados com seu animal de estimação. |**Hobbies, História:** Pedro é jovem e está construindo seu futuro estudando muito e trabalhando para ajudar os pais. Ele é proativo, gosta de ler, ver filmes e frequentar a academia. Está sempre em busca de novidades nas redes sociais e atento às mudanças tecnológicas. Adora animais e acredita que eles merecem cuidados e amor.| 

|   Leila Diniz   |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|![](https://user-images.githubusercontent.com/78277341/157101892-f3a69e6c-8027-4f8c-8940-b66053034dd2.png)|**Idade:** 55 anos - **Ocupação:** Ocupação: Desenvovedora de Software, mãe de 2 filhos e Dona de Casa |Aplicativos: Notion, Agenda Eletônica Google e Instagram.|
|**Motivações:** Leila trabalha em casa como desenvolvedora de Software. Também cria 2 filhos menores e cuida do lar. Para desenvolver afeto e responsabilidade nas crianças, Maria os presenteou com um cachorro de raça Golden Retriever.  |**Frustrações:** A ida regular ao veterinário e a correta vacinação são imprescindíveis para a saúde do Golden Retriever. A raça é propensa a desenvolver diversas doenças ao longo da vida. Leila trabalha o dia todo e cria 2 crianças. Ela precisa de auxílio para acompanhar o desenvolvimento do animal doméstico, como marcação de consultas, vacinação e acompanhamento veterinário.|**Hobbies, História:** Como mãe, Maria sabe que os filhos amam animais e quer ensinar-lhes sobre ter responsabilidade. Como desenvolvedora, ela sabe que pode contar com ferramentas tecnológicas modernas para cuidar de animais domésticos, tais como: aplicativos, agendas eletrônicas e sites. Como profissional em ascensão, gosta de buscar recursos que tornem sua vida mais prática e que a auxilie no êxito de suas atividades profissionais e particulares. | 



| Maria de Lourdes       |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|![](https://user-images.githubusercontent.com/78277341/157104594-19f4d65b-6552-4eab-baf1-a27d1443078d.png)|**Idade:** 69 anos - **Ocupação:** Aposentada, Dona de Casa |Aplicativos: Facebook e Whatsapp.|
|**Motivações:**  Depois de aposentada, Maria passou a criar um casal de Shih-tzu que sempre chamaram atenção dos amigos. O casal teve filhotes e atualmente Maria é proprietária de 6 cães. Ela passou a participar de competições de beleza canina e a investir na criação dessa raça de cães. Idosa, Maria precisa de auxílio para manter todos os animais bem cuidados. |**Frustrações:**  As competições caninas são muito exigentes. O shih-tzu é uma raça de porte pequena e muito frágil. A quantidade de animais dificulta o controle de vacinação e medicação. Ela precisa manter a vacinação em dia e não esquecer das particularidades de cada um de seus pets, como peso, idade, vacinas aplicadas e vacinas à aplicar. Gosta de usar aplicativos no celular mas prefere os de utilização simplificada.  |**Hobbies, História:** Maria é médica aposentada e começou a criar os cães depois que os filhos saíram de casa. Mora com seu marido e além de criar cães de raça, gosta de fazer trabalhos comunitários. Ajuda entidades de apoio, proteção e auxílio aos animais.| 


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|**Leila Diniz** | *Controle das doses de vacina de forma dinâmica*.  | Insentivar e ajudar os filhos a ter responsabilidades com cuidado de seus pets.
|**Maria de Lourdes** | *Controle de crescimento, medicação, idade e tamanho dos animais competidores. Compartilhar de forma prática de gráficos e informações sobre desenvolvimento de cada animal*. | Ter histórico geral dos animais e controle de suas necessidades com medicação, tosa e saúde. 
| **Pedro Góis**  | *Ter o controle de forma digital das vacinas que já foram administradas e a data das próximas doses* | Auxílio nos cuidados com o crescimento do animal. |


## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir. 

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos funcionais, conforme o seu grau de relevância: 

|ID         | Descrição do Requisito                     | Prioridade |
|-----------|--------------------------------------------|------------|
|RF-001 | O sistema deve permitir o cadastro de usuários, com as seguintes informações: nome, email, telefone, senha, foto, data de nascimento.| ALTA | 
|RF-002 | O usuário deverá estar logado para utilizar o sistema     | ALTA |
|RF-003 | O sistema deve permitir que o usuário altere, exclua ou atualize seus dados cadastrais e exclua sua conta em uma área específica  |MÉDIA |
|RF-004 | Após o usuário acessar a aplicação o sistema deve permitir o cadastro de pets, com as seguintes informações: nome, data de nascimento, espécie e raça, peso, foto;  | MÉDIA |
|RF-005 | O sistema deve apresentar na sua tela principal cards com as informações básicas dos pets cadastrados: foto, peso, idade, nome;  | ALTA |
|RF-006 | Cada usuário logado pode cadastrar até 6 animais de estimação que deverá ter seu histórico de vacinação e medicamento  |ALTA  |
|RF-007 | O sistema deve permitir que o usuário altere, exclua ou atualize os dados dos pets;  |ALTA  |
|RF-008 | Se o pet não está em dia com o seu histórico de vacinação e medicamentos: 1. O sistema exibe mensagem informando ao usuário sobre o atraso de vacinação e medicamento; | ALTA |
|RF-009 | O usuário atualiza o histórico após a regularização da vacina e medicamentos;   | BAIXA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve estar em conformidade com os padrões a ser publicados em um ambiente acessível web (Repl.it, GitHub Pages, Heroku); | ALTA | 
|RNF-002| O site deverá ser responsivo permitindo a visualização web e celular de forma adequada  | BAIXA | 
|RNF-003| O site deve possuir um nível satisfatório de desempenho em dispositivos de baixa capacidade  | BAIXA |
|RNF-004| Deve existir um repositório Git para versionamento e controle de documentação do projeto   |  ALTA |
|RNF-005| Projeto deve conter um arquivo README.md detalhando as tecnologias utilizadas, versões e funcionalidades | ALTA |
|RNF-006| Acessibilidade para deficientes visuais  | BAIXA |

## Restrições

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-001| O projeto não poderá ser entregue após 26/06/2022 |
|RE-002| O aplicativo deve se restringir às tecnologias básicas da Web Frontend, podendo fazer uso de bibliotecas que faça a simulação de tecnologias utilizadas no backend.|
|RE-003| A equipe não pode subcontratar o desenvolvimento do trabalho.|

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 


