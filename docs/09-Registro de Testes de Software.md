# Registro de Testes de Software

O presente relatório demonstra as evidências dos testes de software realizados no sistema pela equipe e é baseado no plano de testes definido no [item 8 deste projeto](https://github.com/ICEI-PUC-Minas-PMV-ADS/PetCare/blob/Entrega-final/docs/08-Plano%20de%20Testes%20de%20Software.md).
#
## 1. Login:

Verificamos que a tela de login mostra um campo para que o usuário informe seus dados.
Para acessar o sistema, é necessário realizar o cadastrado.

![img.png](img.png)

Caso não seja cadastrado, o usuário é redirecionado para a tela de Cadastro.



### 2. Testando tela de *Cadastro*:

Na tela de cadastro, é possivel registrar ***nome, email, data de nascimento e senha***.

![img_1.png](img_1.png)

### :point_right: Observações importantes:
Neste ponto, a equipe verificou que:
- Caso o usuário informe senhas diferentes, o sistema realiza a validação e informa o erro: *senhas diferentes*, e não salva os dados do usuário no banco de dados.
- O campo de senha deve voltar a ficar limpo após a monstragem de erro, evitando que o usuário erre novamente.
- Verificou-se que o sistema salvou os dados do usuário no banco de dados com sucesso.
- Após cadastro, o usuário é redirecionado a tela "Login" e é possível acessar o sistema.

#
## 3. Testando a tela *Principal*
Seguindo o plano de testes, realizado o cadastro corretamente e efetuado o login, verficamos que o usuário é encaminhado à página principal da aplicação. Nesta tela, o usuário encontrará o menu na barra lateral com as seguintes ferramentas:
- Meus Pets,
- Minha Conta
- Calendários de vacinas
- Sair do sistema.

Na parte principal da tela, é possivel visualizar a ferramenta “**+**” para inserir os dados do pet. Vejamos:

![i![img_3.png](img_3.png)mg_2.png](img_2.png)
#

## 4. Testando a tela *Minha Conta*:
Nesta ferramenta, verificamos que o usuário poderá alterar seus dados ou excluir sua conta. Para isso, terá que confirmar sua senha..

![img_12.png](img_12.png)
### :point_right: Observações importantes:
Neste ponto, a equipe verificou que:
- Caso o usuário informe a senha incorreta, o sistema informa: *"Não foi possível alterar os dados"*.
- Caso a senha esteja correta, os novos dados são salvos no banco de dados do sistema com sucesso.
- Caso a conta seja excluída, o sistema retorna à pagina de login e só é possível entrar novamente no sistema após realizar um novo cadastro.
  ![img_4.png](img_4.png)

:point_right: Também foi verificado que algumas melhorias devem ser aplicadas:

- Ainda não é possível guardar as imagens ou fotos inseridas pelo usuário no campo do perfil.
#
## 5. Testando a tela *Meus Pets*:

Constatou-se que ao clicar em Meus Pets, o usuário é redirecionado para a tela de cadastro do animal.
Aqui, é possível inserir o **nome, espécie, raça e data de nascimento**.
O sistema também deverá possibilitar o upload da foto ou imagem do animal.

![img_5.png](img_5.png)

### :point_right: Observações importantes:
Neste ponto, a equipe verificou que algumas melhorias devem ser aplicadas:
- Ainda não é possível guardar as imagens ou fotos inseridas pelo usuário.

Inserido os dados do Pet, a tela principal passará a mostrar a imagem, nome e raça do animal.
Agora, dois botões passam a serem exibidos na tela principal: **Cuidar** e **Editar**. Vejamos:

![img_6.png](img_6.png)

## 6. Testando a tela de *editar os dados do Pet*:

Nesta tela, é possível alterar os dados do Pet ou excluir o registro.
Verificamos que, ao alterar o registro, o sistema altera as informações no banco de dados com sucesso.

![img_7.png](img_7.png)



Verificou-se também que, caso o usuário clic em "excluir", todos os dados do animal são devidamente excluídos do sistema e a tela principal volta a ser exibida com a ferramenta de adicionar novo cadastro.

![img_8.png](img_8.png)
#

## 7. Testando ferramenta *Cuidar*:

Esta tela apresenta 3 opções de registro;

- Calendário de Vacinas
- Gráficos de Peso e
- Incluir Vacina/medicamento.

![img_9.png](img_9.png)

#

## 8. Testando ferramenta *Calendário de Vacinas*:

Esta aba, apresentará um calendário que mostrará as datas de vacinas com vencimento próximo.

![image](https://user-images.githubusercontent.com/78277341/143724524-c2d09ec2-7836-4e2b-a218-849187d7dea4.png)

### :point_right: Observações importantes sobre o calendário:
Neste ponto, a equipe verificou que algumas melhorias deverão ser aplicadas:
- Ainda não é possível guardar as informações inseridas na agenda.
- O calendário ainda não está implementado e funcional.
- ainda não é possível relizar notificação sobre datas ao usuário.

#

### 9. Testando *Gráfico de pesos*:

Neste campo, o usuário poderá registrar o peso do pet, para acompanhamento.
A tela mostra um campo para que seja registrado o tipo de pesagem, informações do peso (onde podemos escolher por ***acima do peso, abaixo do peso, peso normal***), podemos informar o ***valor do peso*** e a ***data de pesagem***.

Ao clicarmos em Adcionar, o sistema registra os dados e mostra uma tabela com as informações inseridas.
Também é exibido as ferramentas de edição e exclusão desse cadastro.

![img_10.png](img_10.png)

### :point_right: Observações importantes em Gráfico de Pesos:
Neste ponto, a equipe verificou que algumas melhorias deverão ser aplicadas:
- Devemos implementar a imagem do gráfico, representando o desenvolvimento do peso do pet, conforme o seguinte esboço:

![image](https://user-images.githubusercontent.com/78277341/143724710-5fd5677b-bb4b-45bb-9e0e-9ed63375dbc3.png)
#

### 10. Testando *Incluir Vacinas*:

Na aba incluir vacinas, é possível ***cadastrar o medicamento***, informando sua ***descrição, data, nome e dosagem***.

Também foi verificado que o sistema realiza a ***busca por nome de medicamento*** e a mostra uma tabela com os dados registrados. Vejamos:

![img_11.png](img_11.png)

#

### 10. Vídeo de demonstração:

Clic na imagem abaixo e pega uma pipoca para assistir nosso emocionante vídeo de registro de testes de software. :)

[![Watch the video](https://user-images.githubusercontent.com/78277341/144880982-308d72df-079e-4f8e-a8e6-1bfbeda473de.png)](https://youtu.be/LR2cz3U-OL4)

