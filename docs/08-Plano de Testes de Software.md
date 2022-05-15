# Plano de Testes de Software

Os requisitos para realização dos testes de software são:
- Site publicado na Internet
- Navegador da Internet - Chrome, Firefox ou Edge
- Conectividade de Internet para acesso às plataformas (APISs) 

 

Os testes funcionais a serem realizados no aplicativo são descritos a seguir. 


| **Caso de Teste**  | Login                                                                                                                                                                                                                                                                  |
| ------------------- |------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Requisitos Associados** | A tela de login apresenta um formulário solicitando e-mail e senha do usuário para que ele possa logar no sistema. Os campos devem ser preenchidos com dados previamente cadastrados. Caso o usuário não possua o cadastro no sistema, um alert solicitará o cadastro. |
|  **Objetivo do Teste**  | Verificar se login da página “Acesse sua conta” é efetuado e se após o login a página da conta aparecerá para o usuário.                                                                                                                                               |
|   | **Passos**                                                                                                                                                                                                                                                             
||1) Acessar o Navegador.
||2) Informar o endereço do Site: https://icei-puc-minas-pmv-ads.github.io/PetCare/. 
||3) Visualizar a página principal.
||4) No campo  e-mail, inserir: brunobenetolo@hotmail.com. 
||5) No campo senha, inserir: 123456. 
||6) Clicar em login. 
||7) Visualizar a página de acesso.  |
|  **Critérios de Êxito**  | Ao clicar em Login, deverá ser liberado acesso à conta do usuário.                                                                                                                                                                                                     |


| **Caso de Teste**  | Tela Cadastro                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| ------------------- |-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Requisitos Associados** | Na tela de cadastro, deverá ser possivel registrar ***nome, email, data de nascimento e senha***..                                                                                                                                                                                                                                                                                                                                            |
|  **Objetivo do Teste**  | - Verificar se a ferramenta “Minha Conta” leva para a página de salvar ou excluir dados pessoais. Verificar se a ferramenta “*Meus Pets*” leva para a página de ‘*editar* e *cuidar*”. Verificar se a ferramenta “*editar*” leva para página de salvar ou remover dados do Pet. Verificar se o botão “*cuidar*” leva para a página que consta o “*calendário de vacina*” e as abas de “*gráficos de pesos*” e “*incluir vacina/medicamento*”. |
|   | **Passos**                                                                                                                                                                                                                                                                                                                                                                                                                                    
||1) Acessar o Navegador.
||2) Informar o endereço do Site: https://icei-puc-minas-pmv-ads.github.io/PetCare/.
||3) Efetuar o login (conforme tabela anterior)
||4) Visualizar a  página com o nome do usuário, foto do Pet e barra lateral de ferramentas.
||5) Clicar em “*Minha Conta*” no menu lateral.
||6)  Visualizar a página com os botões “*salvar*” e “*excluir conta*”.
||7) Clicar no botão “*Cuidar*”.
||8) Visualizar a página de calendário.
||9) Clicar na aba Gráfico de pesos
||10) Visualizar o gráfico representativo e campos de adicionar e remover
||11) Clicar na aba “*Incluir Vacina*”
||12) Visualizar os campos de registros com botões “*adicionar*” e “*cancelar*”
|  **Critérios de Êxito**  | As páginas dos passos anteriores devem estar responsivas, com todas as imagens sendo carregadas corretamente.                                                                                                                                                                                                                                                                                                                                 |
#


| **Caso de Teste**  | Tela Principal                                                                                                                                                                                                                                                                                                                                                                                                                                |
| ------------------- |-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Requisitos Associados** | Apresenta a página de acesso, cujo menu lateral possui 3 ferramentas: *Meus Pets*, *Minha Conta* e *Calendário de Vacinas*. Já a página principal deve apresentar dois botões: *editar* e *cuidar*.                                                                                                                                                                                                                                           |
|  **Objetivo do Teste**  | - Verificar se a ferramenta “Minha Conta” leva para a página de salvar ou excluir dados pessoais. Verificar se a ferramenta “*Meus Pets*” leva para a página de ‘*editar* e *cuidar*”. Verificar se a ferramenta “*editar*” leva para página de salvar ou remover dados do Pet. Verificar se o botão “*cuidar*” leva para a página que consta o “*calendário de vacina*” e as abas de “*gráficos de pesos*” e “*incluir vacina/medicamento*”. |
|   | **Passos**                                                                                                                                                                                                                                                                                                                                                                                                                                    
||1) Acessar o Navegador.
||2) Informar o endereço do Site: https://icei-puc-minas-pmv-ads.github.io/PetCare/. 
||3) Efetuar o login (conforme tabela anterior) 
||4) Visualizar a  página com o nome do usuário, foto do Pet e barra lateral de ferramentas.
||5) Clicar em “*Minha Conta*” no menu lateral. 
||6)  Visualizar a página com os botões “*salvar*” e “*excluir conta*”. 
||7) Clicar no botão “*Cuidar*”. 
||8) Visualizar a página de calendário.
||9) Clicar na aba Gráfico de pesos
||10) Visualizar o gráfico representativo e campos de adicionar e remover
||11) Clicar na aba “*Incluir Vacina*”
||12) Visualizar os campos de registros com botões “*adicionar*” e “*cancelar*” 
|  **Critérios de Êxito**  | As páginas dos passos anteriores devem estar responsivas, com todas as imagens sendo carregadas corretamente.                                                                                                                                                                                                                                                                                                                                 |


| **Caso de Teste**  | Tela Meus Pets                                                                                                                                                                                                                 |
| ------------------- |--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Requisitos Associados** | Nesta ferramenta, o usuário deve ser redirecionado para a tela de cadastro do animal.                                                                                                                                          |
|  **Objetivo do Teste**  | -  Inserir o **nome, espécie, raça e data de nascimento** e fazer o upload da foto ou imagem do animal.                                                                                                                        |
|   | **Passos**                                                                                                                                                                                                                     
||1) Registrar o nome, espécie, raça e data de nascimento do pet.
||2) Clicar em salvar.
||3) Efetuar exclusão, clicando em excluir.
|  **Critérios de Êxito**  | O sistema deve salvar os dados do animal no banco de dados. Se o usuário clicar em excluir, todos os dados do animal devem ser apagados do sistema, caso em que o usuário deverá ser redirecionado à tela principal novamente. 

| **Caso de Teste**  | Tela editar os dados do Pet                                                                                                                                                                                                                                                                                                                                                                                                                   |
| ------------------- |-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Requisitos Associados** | Nesta ferramenta, deve ser possível alterar os dados do pet ou excluí-los.                                                                                                                                                                                                                                                                                                                                                                    |
|  **Objetivo do Teste**  | - Verificar se a ferramenta “Minha Conta” leva para a página de salvar ou excluir dados pessoais. Verificar se a ferramenta “*Meus Pets*” leva para a página de ‘*editar* e *cuidar*”. Verificar se a ferramenta “*editar*” leva para página de salvar ou remover dados do Pet. Verificar se o botão “*cuidar*” leva para a página que consta o “*calendário de vacina*” e as abas de “*gráficos de pesos*” e “*incluir vacina/medicamento*”. |
|   | **Passos**                                                                                                                                                                                                                                                                                                                                                                                                                                    
||1) Alterar o nome efetuado no cadastro.
||2) Clicar em salvar.
||3) Efetuar exclusão da conta registrado na tela de cadastro, clicando em excluir.
|  **Critérios de Êxito**  | Os dados só posem ser alterados se a senha for informada corretamente. Caso a senha esteja correta, os novos dados devem serem salvos no banco de dados do sistema. Se não estiver correta a senha, uma mensagem de erro deve ser exibida: "senha incorreta". Caso a conta seja excluída, o sistema deve apagar os dados do usuário.                                                                                                                                                                                                                                                                             

| **Caso de Teste**  | Tela Cuidar                                                                                                                                                                                                                    |
| ------------------- |--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Requisitos Associados** | Esta tela apresenta 3 opções de registro: Calendário de Vacinas, Gráficos de Peso e Incluir Vacina/medicamento.                                                                                                                |
|  **Objetivo do Teste**  | Verificar se as abas estão sendo exibidas                                                                                                                                                                                      |
|   | **Passos**
||1) Clicar nas três abas.
|  **Critérios de Êxito**  | As três abas estão sendo exibidas.

| **Caso de Teste**  | Tela Calendário                                                                                                 |
| ------------------- |-----------------------------------------------------------------------------------------------------------------|
| **Requisitos Associados** | Esta tela apresenta 3 opções de registro: Calendário de Vacinas, Gráficos de Peso e Incluir Vacina/medicamento. |
|  **Objetivo do Teste**  | Verificar se as abas estão sendo exibidas                                                                       |
|   | **Passos**                                                                                                      
||1) Clicar nas três abas.
|  **Critérios de Êxito**  | As três abas estão sendo exibidas.   

| **Caso de Teste**  | Gráfico de Pesos                                                                                                 |
| ------------------- |-----------------------------------------------------------------------------------------------------------------|
| **Requisitos Associados** | Esta tela apresenta o gráfico baseado no histórico de pesagens e 4 campos para registro de nova pesagem: Descrição, Observação peso e data da pesagem. |
|  **Objetivo do Teste**  | Verificar se o gráfico está exibindo os dados corretamente de acordo com a tabela de histórico de pesagens, verificar se os inputs estão capturando os dados e os registrando corretamente.                                                                       |
|   | **Passos**                                                                                                      
||1) Inserir os dados nos campos para cadastrar nova pesagem e clicar em adicionar.
|  **Critérios de Êxito**  | Dados adicionados com êxito.
||2) Clicar no botão remover para remover dados de pesagem.
|  **Critérios de Êxito**  | Dados dados removidos com êxito. 

#
## Ferramentas de Testes
Para realizar os testes e verificar a responsividade das páginas, foram utilizados:
- Computadores
- Celulares Android e iOS
- Debugging Visual Studio Code
- Ferramenta de inspeção do Google Chrome


