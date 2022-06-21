# Registro de Testes de Software

O presente relatório demonstra as evidências dos testes de software realizados no sistema pela equipe e é baseado no plano de testes definido no [item 8 deste projeto](https://github.com/ICEI-PUC-Minas-PMV-ADS/PetCare-/blob/main/docs/08-Plano%20de%20Testes%20de%20Software.md).

## 1. Login:
Seguindo o plano de testes, iniciamos as verificações pela tela de login. 
Verificamos que a tela mostra um campo para que o usuário informe seus dados.
Para acessar o sistema, é necessário realizar o cadastrado.

![image](https://user-images.githubusercontent.com/78277341/168466558-67571ffb-be65-4c3c-981e-ba53ad9b1a58.png)


Caso não seja cadastrado, o usuário é redirecionado para a tela de Cadastro.
O usuário deve informar seus dados para ter acesso ao sistema.

- caso a senha esteja errada, uma mensagm de erro é informada: "*Não foi possivel fazer seu login. Tente novamente!"*

![image](https://user-images.githubusercontent.com/78277341/174906654-718af486-8a7a-4819-9759-d1ec7cd93004.png)


## 2. Testando tela de *Cadastrar usuários*:

Na tela de cadastro, é possivel registrar ***nome, email, data de nascimento e senha***.

![image](https://user-images.githubusercontent.com/78277341/174906780-dbdc70de-ebee-4db9-aab7-06cb71e06ebf.png)

### :point_right: Observações importantes:
Neste ponto, a equipe verificou que:
- Caso o usuário informe senhas diferentes, o sistema realiza a validação e informa o erro: *senhas diferentes*, e não salva os dados do usuário no banco de dados.
- O campo de senha deve voltar a ficar limpo após a monstragem de erro, evitando que o usuário erre novamente.
- Verificou-se que o sistema salvou os dados do usuário no banco de dados com sucesso.
- Após cadastro, o usuário é redirecionado a tela "Login" e é possível acessar o sistema.


## 3. Testando a tela *Principal*
Seguindo o plano de testes, realizado o cadastro corretamente e efetuado o login, verficamos que o usuário é encaminhado à página principal da aplicação. Nesta tela, o usuário encontrará o menu na barra lateral com as seguintes ferramentas:
- Meus Pets,
- Minha Conta
- Calendários de vacinas
- Sair do sistema.

Na parte principal da tela, é possivel visualizar a ferramenta “**+**” para inserir os dados do pet. Vejamos:

![image](https://user-images.githubusercontent.com/78277341/174906970-384620bb-915d-4bd8-b6cb-5fef851261e1.png)

## 4. Testando a tela *Editar Minha Conta*:
Nesta ferramenta, verificamos que o usuário poderá alterar seus dados ou excluir sua conta. Para isso, terá que confirmar sua senha..

![image](https://user-images.githubusercontent.com/78277341/174907127-3e79ccb2-9926-4954-93c0-80e13c11e761.png)

### :point_right: Observações importantes:
Neste ponto, a equipe verificou que:
- Caso o usuário informe a senha incorreta, o sistema informa: *"Não foi possível alterar os dados"*.
- Caso a senha esteja correta, os novos dados são salvos no banco de dados do sistema com sucesso.
- Caso a conta seja excluída, o sistema retorna à pagina de login e só é possível entrar novamente no sistema após realizar um novo cadastro.


:point_right: É possível guardar as imagens ou fotos inseridas pelo usuário no campo do perfil.

## 5. Testando a tela *Meus Pets*:

Constatou-se que ao clicar em Meus Pets, o usuário é redirecionado para a tela de cadastro do animal.
Aqui, é possível inserir o **nome, espécie, raça e data de nascimento**.
O sistema também deverá possibilitar o upload da foto ou imagem do animal.

![image](https://user-images.githubusercontent.com/78277341/174908072-0185c941-2fdb-4f77-a491-53edf8d630c4.png)

### :point_right: Observações importantes:
:point_right: É possível guardar as imagens ou fotos inseridas pelo usuário no campo do Pet.

Inserido os dados do Pet, a tela principal passará a mostrar a imagem, nome e raça do animal.

Agora, dois botões passam a serem exibidos na tela principal: **Cuidar** e **Editar**. Vejamos:

![image](https://user-images.githubusercontent.com/78277341/174910338-a5802343-e0b8-4306-822e-4fa764188558.png)

## 6. Testando a tela de *editar os dados do Pet*:

Nesta tela, é possível alterar os dados do Pet ou excluir o registro.
Verificamos que, ao alterar o registro, o sistema altera as informações no banco de dados com sucesso.

Verificou-se também que, caso o usuário clic em "excluir", todos os dados do animal são devidamente excluídos do sistema e a tela principal volta a ser exibida com a ferramenta de adicionar novo cadastro.

![image](https://user-images.githubusercontent.com/78277341/174910544-9ae6f687-93c8-4cac-8339-6637c7127bb8.png)

## 7. Testando ferramenta *Cuidar*:

Esta tela apresenta 3 opções de registro;

- Calendário de Vacinas
- Gráficos de Peso e
- Incluir Vacina/medicamento.

## 8. Testando ferramenta *Calendário de Vacinas*:

Esta aba, apresentará um calendário que mostrará as datas de vacinas com vencimento próximo.

![image](https://user-images.githubusercontent.com/78277341/174911217-47781712-0bf0-44db-ba8c-e3f8b13cea3c.png)

### :point_right: Observações importantes sobre o calendário:
Neste ponto, a equipe verificou que algumas melhorias deverão ser aplicadas:
- É possível guardar as informações inseridas na agenda.
- O calendário ainda está implementado e funcional.
- É possível relizar notificação sobre datas ao usuário.


## 9. Testando *Gráfico de pesos*:

Neste campo, o usuário poderá registrar o peso do pet, para acompanhamento.
A tela mostra um campo para que seja registrado o tipo de pesagem, informações do peso (onde podemos escolher por ***acima do peso, abaixo do peso, peso normal***), podemos informar o ***valor do peso*** e a ***data de pesagem***.

Ao clicarmos em Adicionar, o sistema registra os dados e mostra uma tabela com as informações inseridas.
Também é exibido as ferramentas de edição e exclusão desse cadastro.

![image](https://user-images.githubusercontent.com/78277341/174910843-97ca77d7-ae03-41c3-b8b1-130cc2742891.png)

## 10. Testando *Incluir Vacinas*:

Na aba incluir vacinas, é possível ***cadastrar o medicamento***, informando sua ***descrição, data, nome e dosagem***.

Também foi verificado que o sistema realiza a ***busca por nome de medicamento*** e também exibe uma tabela com os dados registrados. Vejamos:

![image](https://user-images.githubusercontent.com/78277341/174910932-c5336942-3b8b-4326-813a-62767cfd7635.png)


## 11. Vídeo de demonstração🍿:

Clica na imagem abaixo e pega uma pipoca para assistir nosso emocionante vídeo de registro de testes de software. :)

[![Watch the video](https://user-images.githubusercontent.com/78277341/144880982-308d72df-079e-4f8e-a8e6-1bfbeda473de.png)](https://youtu.be/LR2cz3U-OL4)

