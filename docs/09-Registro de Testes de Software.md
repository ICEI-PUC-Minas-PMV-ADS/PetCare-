# Registro de Testes de Software

O presente relatório demonstra as evidências dos testes de software realizados no sistema pela equipe e é baseado no plano de testes definido no [item 8 deste projeto](https://github.com/ICEI-PUC-Minas-PMV-ADS/PetCare-/blob/main/docs/08-Plano%20de%20Testes%20de%20Software.md).

## 1. Login:

Verificamos que a tela de login mostra um campo para que o usuário informe seus dados.
Para acessar o sistema, é necessário realizar o cadastrado.

![image](https://user-images.githubusercontent.com/78277341/168466558-67571ffb-be65-4c3c-981e-ba53ad9b1a58.png)


Caso não seja cadastrado, o usuário é redirecionado para a tela de Cadastro.
O usuário deve informar seus dados para ter acesso ao sistema.

- caso a senha esteja errada, uma mensagm de erro é informada: "*não é possível fazer seu login, tente novamente."*

![image](https://user-images.githubusercontent.com/78277341/168466923-f5b70577-6753-432c-b87c-b04949751f2d.png)


## 2. Testando tela de *Cadastro*:

Na tela de cadastro, é possivel registrar ***nome, email, data de nascimento e senha***.

![image](https://user-images.githubusercontent.com/78277341/168466604-1840a37c-bffb-409f-a66f-bb94a11709b5.png)

### :point_right: Observações importantes:
Neste ponto, a equipe verificou que:
- Caso o usuário informe senhas diferentes, o sistema realiza a validação e informa o erro: *senhas diferentes*, e não salva os dados do usuário no banco de dados.
- O campo de senha deve voltar a ficar limpo após a monstragem de erro, evitando que o usuário erre novamente.
- Verificou-se que o sistema salvou os dados do usuário no banco de dados com sucesso.
- Após cadastro, o usuário é redirecionado a tela "Login" e é possível acessar o sistema.

#
### 3. Testando a tela *Principal*
Seguindo o plano de testes, realizado o cadastro corretamente e efetuado o login, verficamos que o usuário é encaminhado à página principal da aplicação. Nesta tela, o usuário encontrará o menu na barra lateral com as seguintes ferramentas:
- Meus Pets,
- Minha Conta
- Calendários de vacinas
- Sair do sistema.

Na parte principal da tela, é possivel visualizar a ferramenta “**+**” para inserir os dados do pet. Vejamos:

![image](https://user-images.githubusercontent.com/78277341/168466998-5506260b-85e1-4d41-bed2-0d4852ac45ea.png)
#

## 4. Testando a tela *Minha Conta*:
Nesta ferramenta, verificamos que o usuário poderá alterar seus dados ou excluir sua conta. Para isso, terá que confirmar sua senha..

![image](https://user-images.githubusercontent.com/78277341/168467041-42bbcac8-a207-40bc-9ff5-17d0a8e7eed5.png)
### :point_right: Observações importantes:
Neste ponto, a equipe verificou que:
- Caso o usuário informe a senha incorreta, o sistema informa: *"Não foi possível alterar os dados"*.
- Caso a senha esteja correta, os novos dados são salvos no banco de dados do sistema com sucesso.
- Caso a conta seja excluída, o sistema retorna à pagina de login e só é possível entrar novamente no sistema após realizar um novo cadastro.


  ![image](https://user-images.githubusercontent.com/78277341/168467172-206c1d78-3a4c-4050-a2c5-606ee6786889.png)

:point_right: Também foi verificado que algumas melhorias devem ser aplicadas:

- Ainda não é possível guardar as imagens ou fotos inseridas pelo usuário no campo do perfil.
#
## 5. Testando a tela *Meus Pets*:

Constatou-se que ao clicar em Meus Pets, o usuário é redirecionado para a tela de cadastro do animal.
Aqui, é possível inserir o **nome, espécie, raça e data de nascimento**.
O sistema também deverá possibilitar o upload da foto ou imagem do animal.

![image](https://user-images.githubusercontent.com/78277341/168467201-bbd63e4d-a5fe-4e76-817a-29fbdaefff8e.png)

### :point_right: Observações importantes:
Neste ponto, a equipe verificou que algumas melhorias devem ser aplicadas:
- Ainda não é possível guardar as imagens ou fotos inseridas pelo usuário.

Inserido os dados do Pet, a tela principal passará a mostrar a imagem, nome e raça do animal.
Agora, dois botões passam a serem exibidos na tela principal: **Cuidar** e **Editar**. Vejamos:

![image](https://user-images.githubusercontent.com/78277341/168467226-7169c963-2dd0-4c44-b0ed-2ef3950c070d.png)

## 6. Testando a tela de *editar os dados do Pet*:

Nesta tela, é possível alterar os dados do Pet ou excluir o registro.
Verificamos que, ao alterar o registro, o sistema altera as informações no banco de dados com sucesso.

![image](https://user-images.githubusercontent.com/78277341/168467287-80f772f9-1d81-4c5b-9e32-2dcb37b7fd63.png)



Verificou-se também que, caso o usuário clic em "excluir", todos os dados do animal são devidamente excluídos do sistema e a tela principal volta a ser exibida com a ferramenta de adicionar novo cadastro.

![image](https://user-images.githubusercontent.com/78277341/168467352-70eccf75-28d6-4f9b-aecc-9213eaf6ff0c.png)

## 7. Testando ferramenta *Cuidar*:

Esta tela apresenta 3 opções de registro;

- Calendário de Vacinas
- Gráficos de Peso e
- Incluir Vacina/medicamento.


![image](https://user-images.githubusercontent.com/78277341/168467377-009081e0-6e12-421d-888d-7eeecf09273c.png)



## 8. Testando ferramenta *Calendário de Vacinas*:

Esta aba, apresentará um calendário que mostrará as datas de vacinas com vencimento próximo.

![image](https://user-images.githubusercontent.com/78277341/143724524-c2d09ec2-7836-4e2b-a218-849187d7dea4.png)

### :point_right: Observações importantes sobre o calendário:
Neste ponto, a equipe verificou que algumas melhorias deverão ser aplicadas:
- Ainda não é possível guardar as informações inseridas na agenda.
- O calendário ainda não está implementado e funcional.
- ainda não é possível relizar notificação sobre datas ao usuário.


## 9. Testando *Gráfico de pesos*:

Neste campo, o usuário poderá registrar o peso do pet, para acompanhamento.
A tela mostra um campo para que seja registrado o tipo de pesagem, informações do peso (onde podemos escolher por ***acima do peso, abaixo do peso, peso normal***), podemos informar o ***valor do peso*** e a ***data de pesagem***.

Ao clicarmos em Adcionar, o sistema registra os dados e mostra uma tabela com as informações inseridas.
Também é exibido as ferramentas de edição e exclusão desse cadastro.

![image](https://user-images.githubusercontent.com/78277341/168467428-614e4894-97ef-45ca-bc19-cdcec9736ea7.png)

### :point_right: Observações importantes em Gráfico de Pesos:
Neste ponto, a equipe verificou que algumas melhorias deverão ser aplicadas:
- Devemos implementar a imagem do gráfico, representando o desenvolvimento do peso do pet, conforme o seguinte esboço:

![image](https://user-images.githubusercontent.com/78277341/143724710-5fd5677b-bb4b-45bb-9e0e-9ed63375dbc3.png)

## 10. Testando *Incluir Vacinas*:

Na aba incluir vacinas, é possível ***cadastrar o medicamento***, informando sua ***descrição, data, nome e dosagem***.

Também foi verificado que o sistema realiza a ***busca por nome de medicamento*** e a mostra uma tabela com os dados registrados. Vejamos:

![image](https://user-images.githubusercontent.com/78277341/168467457-c72b1c30-2410-44ab-a096-eca5d71445af.png)


## 11. Vídeo de demonstração:

Clic na imagem abaixo e pega uma pipoca para assistir nosso emocionante vídeo de registro de testes de software. :)

[![Watch the video](https://user-images.githubusercontent.com/78277341/144880982-308d72df-079e-4f8e-a8e6-1bfbeda473de.png)](https://youtu.be/LR2cz3U-OL4)

