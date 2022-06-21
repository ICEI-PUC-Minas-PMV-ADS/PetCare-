# Plano de Testes de Usabilidade

Para o presente registro de testes, verificamos todas as etapas definidas no
[Plano de testes de usuabilidade](https://github.com/ICEI-PUC-Minas-PMV-ADS/PetCare-/blob/main/docs/10-Plano%20de%20Testes%20de%20Usabilidade.md).
As etapas foram realizadas sobre o ponto de vista do usuário e trabalhando em uma série de tarefas, em busca de fontes de dificuldades, erros ou inconsistências no sistema.
O objetivo é verificarmos os erros para eliminarmos quaisquer problema de usabilidade.
Para tanto, foi realizado um teste remoto e teste presencial.

|   | **Etapas**
| ------------------- | ------------------- |
||1) Análise Heurística;
||2) Definição de Tarefas, Questionário e Métricas;
||3) Execução dos Testes;
||4) Análise do Teste;
||5) Avaliação da aplicação por meio de Heurística.

|   | **Passo a passo**
| ------------------- | ------------------- |
||1) Selecionadas 05 pessoas para análise da aplicação.
||2) Foi enviado para cada o link da nossa aplicação juntamente com o vídeo explicativo de como navegar por ela e o formulário onde encontram os pontos a serem analisados como descrito abaixo.
||3) 1º desafio: se cadastrar e logar na aplicação.
||4) 2º desafio: editar o cadastro de usuário e enviar uma foto salvando-a no sistema.
||5) 2º desafio: realizar o cadastro de um pet e editar dados em seguida, salvando os novos dados no sistema.
||6) 3º desafio: inserir dados de vacina e medicamento no calendário.
||7) Navegar pela aplicação naturalmente, como se estivesse realizando a ação em suas casas.
||8) Sair da aplicaçao.
||8) Logar novamentena aplicaçao e verificar que os dados do usuário e seu pet estão salvos e disponíveis.

|   | **Resultados avaliados pós teste**
| ------------------- | ------------------- |
||1) Escala de dificuldade da tarefa - ✅ **muito fácil**.
||2) Expectativa x realidade: escala de dificuldade antes e depois de fazer a tarefa (✅ **muito fácil**).
||3) Escala de insatisfação (👍 **Satisfeito**).
||4) Em geral como avalia a aplicação? (escala de 1 a 10 onde 1 é péssimo e 10 excelente) = 👍**8**.
||5) Navegar na aplicação foi tranquilo? (escala de 1 a 10 onde 1 é difícil e 10 fácil) = 👍**10**.
||7) Recomendaria a nossa aplicação?  (escala de 1 a 10 onde 1 é muito improvável e 10 muito provável) = 👍**10**
||8) Problemas observados = *"A data de nascimento aceita qualquer numeração inserida pelo usuário."*.
||9) Tempo de execução para concluir cada tarefa = *de 30 segundos a 1 minutos*.

Para esta etapa do projeto, os testes serão realizados nas principais funcionalidades do sistema: login, cadastro do usuário, cadastro do pet e cadastro de vacinas e clendário. Além dos botões editar perfil e sair.

|Tarefa 1| Critério de êxito                                                              | Status                      |
|--------|--------------------------------------------------------------------------------|-----------------------------|
|Fazer o login no sistema | Usuário conseguiu logar no sistema e ser encaminhado para a página de cadastro | ✅ Concretização da tarefa .

| Tarefa 2                           | Critério de êxito                                                                               | Status                               |
|------------------------------------|-------------------------------------------------------------------------------------------------|--------------------------------------------------|
| Cadastro de novo usuário           | Usuário conseguiu efetivar o cadastro, considerando a mensagem "Cadastro realizado com sucesso" | ✅ Concretização da tarefa em menos de um minuto. |
| Inserir foto do novo usuário       | Usuário conseguiu enviar e salvar foto com sucesso.                                             | ✅ Concretização da tarefa em menos de um minuto. |
| Editar dados do usuário cadastrado | Usuário conseguiu editar e salvar dados com sucesso.                                            | ✅ Concretização da tarefa em menos de um minuto. |

| Tarefa 3                    | Critério de êxito                                                                | Status                                                                                                   |
|-----------------------------|----------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------|
| Cadastro de novo pet        | Concluir o cadastro, considerando a mensagem "Cadastro realizado com sucesso"    | ✅ Concretização da tarefa. Quantidade de erros cometidos = 2. Tempo necessário para se concluir = menos de um minuto |
| Editar cadastro de pet | Usuário conseguiu editar o cadastro, considerando a mensagem "Salvo com sucesso" | ✅ Concretização da tarefa. Quantidade de erros cometidos = 0. Tempo necessário para se concluir = 30 segundos        |

| Tarefa 4                   | Critério de êxito                                                     | Status                                                                                         |
|----------------------------|-----------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------|
| Cadastro de vacina do pet  | Inserir nome da vacina no item calendário, salvando o nome no campo.  | ✅ Concretização da tarefa. Quantidade de erros cometidos = 0. Tempo necessário para se concluir = 1 minuto |
| Calendário de datas do pet | Inserir datas especiais no item calendário, salvando o nome no campo. | ✅ Concretização da tarefa. Quantidade de erros cometidos = 0. Tempo necessário para se concluir = 1 minuto |
| Inserir fotos do pet       | Inserir foto do pet no item perfil, salvando-a no campo.              | ✅ Concretização da tarefa. Quantidade de erros cometidos = 0. Tempo necessário para se concluir = 1 minuto |

| Tarefa 5                   | Critério de êxito                                                                    | Status                                                                                                                |
|----------------------------|--------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------|
| Sair do sistema            | O usuário consegue sair do sistema facilmente.                                       | ✅ Concretização da tarefa. <br/>Quantidade de erros cometidos = 0. <br/>Tempo necessário para se concluir = 1 segundo |
| Logar novamente no sistema | Usuário consegue logar novamente e verificar que seus dados foram salvos no sistema. | ✅ Concretização da tarefa. <br/>Quantidade de erros cometidos = 0. <br/>Tempo necessário para se concluir = 1 minuto  |

### Principais observações

Observou-se que os usuários:

- Permaneceram com resposta emocional "confiante" durante o uso do sistema, recuperando-se rapidamente de eventuais erros.
- Não sairam do fluxo cognitivo pré estabelecido pelo sistema.
- Ainda é necessário estabelecer um critério de datas de nascimento, uma vez que o usuário poderá inserir qualquer numeração.
#
## Ferramentas de Testes
Para realizar os testes e verificar a responsividade das páginas, foram utilizados:
- Computadores
- Celulares Android e iOS.gov/how-to-and-tools/resources/templates.html)

