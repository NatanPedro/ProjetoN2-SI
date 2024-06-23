Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.IO
Imports System.Net.Configuration
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Windows.Documents
Imports ADODB
Imports LiveCharts
Imports Microsoft.SqlServer.Server

Module Mod_global
    Public Structure DadosProduto
        Public Property Data As String
        Public Property NomeProduto As String
        Public Property QuantidadeDisponivel As Integer
        Public Property ValorUnitario As Decimal
    End Structure
    Public diretorio, SQL As String
    Public db As OleDbConnection ' Usar OleDbConnection para conexão com Access
    Public rs As OleDbDataReader ' Usar OleDbDataReader para ler dados do Access
    Public caminho_banco As String = Application.StartupPath & "\Banco_dados\banco.mdb"
    Public cont As Integer
    ' Método para conectar ao banco de dados
    Sub conectar_banco()
        Try
            db = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & caminho_banco)
            db.Open()
            MsgBox("Conexão bem sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Public Sub Puxar_campos_editar(ProdutoID As Integer, txtNome As TextBox, txtCategoria As TextBox, txtQuantidade As TextBox, txtCusto As TextBox, txtPrecoVenda As TextBox, ByRef caminho As String)
        ' Verifica se a conexão foi inicializada
        If db Is Nothing Then
            Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'ConectarBanco()' primeiro.")
        End If

        ' Abre a conexão se estiver fechada
        If db.State = ConnectionState.Closed Then
            db.Open()
        End If

        ' SQL query para buscar dados com base no ProdutoID
        Dim query As String = "SELECT Nome, Categoria, Quantidade, Custo, PrecoVenda, Caminho FROM tb_Produtos WHERE Código = @ProdutoID"

        ' Criar um comando
        Using command As New OleDbCommand(query, db)
            ' Adicionar o parâmetro ao comando
            command.Parameters.AddWithValue("@ProdutoID", ProdutoID)

            Try
                ' Executar o comando e obter os dados usando OleDbDataReader
                Using reader As OleDbDataReader = command.ExecuteReader()
                    ' Verificar se há dados retornados pela consulta
                    If reader.HasRows Then
                        reader.Read()
                        ' Atribuir os dados aos TextBoxes
                        txtNome.Text = reader("Nome").ToString()
                        txtCategoria.Text = reader("Categoria").ToString()
                        txtQuantidade.Text = (reader("quantidade")).ToString()
                        txtCusto.Text = Convert.ToDecimal(reader("Custo")).ToString("F2")
                        txtPrecoVenda.Text = Convert.ToDecimal(reader("PrecoVenda")).ToString("F2")
                        caminho = reader("Caminho").ToString()
                        ' Carregar a foto usando o caminho fornecido
                    Else
                        MessageBox.Show("Nenhum dado encontrado para o ID fornecido.")
                    End If
                End Using
            Catch ex As Exception
                ' Tratar erros que possam ocorrer
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
        End Using
    End Sub
    ' Método para verificar o login
    Public Function VerificarLogin(ByVal usuario As String, ByVal senha As String) As Boolean
        Dim loginCorreto As Boolean = False

        Try
            ' Verifica se a conexão foi inicializada
            If db Is Nothing Then
                Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'conectar_banco()' primeiro.")
            End If
            ' Abre a conexão se estiver fechada
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If
            ' Consulta para verificar se o usuário e a senha correspondem a um registro na tabela Login
            Dim query As String = "SELECT COUNT(*) FROM tb_Funcionarios WHERE Usuario = @Usuario AND Senha = @Senha"
            Using cmd As New OleDbCommand(query, db)
                cmd.Parameters.AddWithValue("@Usuario", usuario)
                cmd.Parameters.AddWithValue("@Senha", senha)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    loginCorreto = True ' Se houver um registro correspondente na tabela, o login é válido
                End If

            End Using
        Catch ex As Exception
            MsgBox("Erro ao verificar login: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        Finally
            ' Fecha a conexão se estiver aberta
            If db IsNot Nothing AndAlso db.State = ConnectionState.Open Then
                db.Close()
            End If
        End Try
        Return loginCorreto
    End Function
    Public Function CadastrarProdutos(Nome As String, Categoria As String, qtd_produto As Integer, Custo As Decimal, PrecoVenda As Decimal, FotoCaminho As String) As String
        Try
            ' Verifica se a conexão foi inicializada
            If db Is Nothing Then
                Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'conectar_banco()' primeiro.")
            End If

            ' Abre a conexão se estiver fechada
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If

            ' Verificar se o produto já existe pelo nome
            If ProdutoExiste(Nome) Then
                Return "Já existe um produto cadastrado com o nome fornecido."
            End If

            ' Consulta para inserir um novo produto na tabela Produtos
            Dim query As String = "INSERT INTO tb_Produtos (Nome, Categoria, Custo, PrecoVenda, Quantidade, Caminho) VALUES (@Nome, @Categoria, @Custo, @PrecoVenda, @Quantidade, @Caminho)"
            Using cmd As New OleDbCommand(query, db)
                cmd.Parameters.AddWithValue("@Nome", Nome)
                cmd.Parameters.AddWithValue("@Categoria", Categoria)
                cmd.Parameters.AddWithValue("@Custo", Custo)
                cmd.Parameters.AddWithValue("@PrecoVenda", PrecoVenda)
                cmd.Parameters.AddWithValue("@Quantidade", qtd_produto)
                cmd.Parameters.AddWithValue("@Caminho", FotoCaminho)

                cmd.ExecuteNonQuery()
            End Using

            ' Retornar mensagem de sucesso
            Return "Produto cadastrado com sucesso."
        Catch ex As Exception
            ' Retornar mensagem de erro
            Return "Erro ao cadastrar produto: " & ex.Message
        Finally
            ' Fecha a conexão se estiver aberta
            If db IsNot Nothing AndAlso db.State = ConnectionState.Open Then
                db.Close()
            End If
        End Try
    End Function

    Private Function ProdutoExiste(NomeProduto As String) As Boolean
        Dim queryVerificar As String = "SELECT COUNT(*) FROM tb_Produtos WHERE Nome = @NomeProduto"
        Using cmdVerificar As New OleDbCommand(queryVerificar, db)
            cmdVerificar.Parameters.AddWithValue("@NomeProduto", NomeProduto)
            Dim count As Integer = Convert.ToInt32(cmdVerificar.ExecuteScalar())
            Return count > 0 ' Retorna verdadeiro se houver algum produto com o mesmo nome
        End Using
    End Function

    Public Function CadastrarFornecedores(CNPJ As String, nome As String, telefone As String, email As String) As String
        Try
            If db Is Nothing Then
                Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'conectar_banco()' primeiro.")
            End If
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If
            Dim queryFornecedores As String = "INSERT INTO tb_Fornecedores (CNPJ, Nome, Telefone, Email) VALUES (@CNPJ, @Nome, @Telefone, @Email)"
            Using cmdFornecedor As New OleDbCommand(queryFornecedores, db)
                cmdFornecedor.Parameters.AddWithValue("@CNPJ", CNPJ)
                cmdFornecedor.Parameters.AddWithValue("@Nome", nome)
                cmdFornecedor.Parameters.AddWithValue("@Telefone", telefone)
                cmdFornecedor.Parameters.AddWithValue("@Email", email)

                cmdFornecedor.ExecuteNonQuery()
            End Using
            Return "Fornecedor cadastrado com sucesso"
        Catch ex As Exception
            Return "Erro ao cadastrar fornecedor" & ex.Message
        End Try
    End Function
    Public Sub CadastrarPedidos(Data As String, Quantidade As Integer, NomeProduto As String, valorUnitario As Decimal, total As Decimal, ProdutoID As Integer)
        Try
            ' Verifica se a conexão foi inicializada
            If db Is Nothing Then
                Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'conectar_banco()' primeiro.")
            End If

            ' Abre a conexão se estiver fechada
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If

            ' Inicia uma transação
            Dim transaction As OleDbTransaction = db.BeginTransaction()

            Try
                ' Converte a string de data em um objeto DateTime
                Dim dataPedido As DateTime
                If Not DateTime.TryParse(Data, dataPedido) Then
                    Throw New ArgumentException("A data fornecida é inválida.")
                End If

                ' Insere o pedido na tabela tb_pedidos
                Dim queryPedido As String = "INSERT INTO tb_pedidos (Data, Quantidade, NomeProduto, ValorUnitario, ValorTotal) VALUES (@Data, @Quantidade, @NomeProduto, @ValorUnitario, @ValorTotal)"
                Using cmdPedido As New OleDbCommand(queryPedido, db, transaction)
                    cmdPedido.Parameters.AddWithValue("@Data", dataPedido)
                    cmdPedido.Parameters.AddWithValue("@Quantidade", Quantidade)
                    cmdPedido.Parameters.AddWithValue("@NomeProduto", NomeProduto)
                    cmdPedido.Parameters.AddWithValue("@ValorUnitario", valorUnitario)
                    cmdPedido.Parameters.AddWithValue("@ValorTotal", total)
                    cmdPedido.ExecuteNonQuery()
                End Using

                ' Atualiza a quantidade do produto na tabela tb_Produtos
                AtualizarProdutos(ProdutoID, Quantidade, transaction)

                ' Confirma a transação
                transaction.Commit()
                MessageBox.Show("Pedido cadastrado e estoque atualizado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                ' Desfaz a transação em caso de erro
                transaction.Rollback()
                MessageBox.Show("Erro ao cadastrar pedido e atualizar estoque: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            MessageBox.Show("Erro ao processar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Fecha a conexão se estiver aberta
            If db IsNot Nothing AndAlso db.State = ConnectionState.Open Then
                db.Close()
            End If
        End Try
    End Sub

    Public Sub AtualizarProdutos(ProdutoID As Integer, Quantidade As Integer, transaction As OleDbTransaction)
        Dim queryUpdateProduto As String = "UPDATE tb_Produtos SET Quantidade = Quantidade - @Quantidade WHERE Código = @ProdutoID"
        Using cmdUpdateProduto As New OleDbCommand(queryUpdateProduto, db, transaction)
            cmdUpdateProduto.Parameters.AddWithValue("@Quantidade", Quantidade)
            cmdUpdateProduto.Parameters.AddWithValue("@ProdutoID", ProdutoID)
            cmdUpdateProduto.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub CarregarDadosProdutos(ProdutoID As Integer, txtNome As TextBox, txtQuantidade As TextBox, txtValorUnitario As TextBox)
        '' Verifica se a conexão foi inicializada
        If db Is Nothing Then
            Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'ConectarBanco()' primeiro.")
        End If
        ' Abre a conexão se estiver fechada
        If db.State = ConnectionState.Closed Then
            db.Open()
        End If
        ' SQL query para buscar dados com base no ProdutoID
        Dim query As String = "SELECT Nome, precoVenda, quantidade FROM tb_Produtos WHERE Código = @ProdutoID"
        ' Criar um comando
        Using command As New OleDbCommand(query, db)
            ' Adicionar o parâmetro ao comando
            command.Parameters.AddWithValue("@ProdutoID", ProdutoID)

            Try
                ' Executar o comando e obter os dados usando OleDbDataReader
                Using reader As OleDbDataReader = command.ExecuteReader()
                    ' Verificar se há dados retornados pela consulta
                    If reader.HasRows Then
                        reader.Read()
                        ' Atribuir os dados aos TextBoxes
                        txtNome.Text = reader("Nome").ToString()
                        txtQuantidade.Text = reader("quantidade").ToString()
                        txtValorUnitario.Text = reader("precoVenda").ToString()
                    Else
                        MessageBox.Show("Nenhum dado encontrado para o ID fornecido.")
                    End If
                End Using
            Catch ex As Exception
                ' Tratar erros que possam ocorrer
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
        End Using
    End Sub
    Public Sub carregar_dados(dataGridView As DataGridView)
        Try
            ' Verifica se a conexão foi inicializada
            If db Is Nothing Then
                Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'conectar_banco()' primeiro.")
            End If
            ' Abre a conexão se estiver fechada
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If
            ' Consulta para obter todos os produtos
            Dim query As String = "SELECT * FROM tb_Produtos"
            Dim cmd As New OleDbCommand(query, db)
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable

            ' Preenche o DataTable com os dados da consulta
            adapter.Fill(dt)

            ' Define o DataSource do DataGridView como o DataTable preenchido
            dataGridView.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao processar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Public Sub Carrega_Dados_Pedidos(dataGridView As DataGridView)
        Try
            ' Verifica se a conexão foi inicializada
            If db Is Nothing Then
                Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'conectar_banco()' primeiro.")
            End If

            ' Abre a conexão se estiver fechada
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If
            ' Consulta para obter todos os pedidos
            Dim query As String = "SELECT Código, Data, Quantidade, ValorTotal, NomeCliente FROM tb_pedidos"

            Dim cmd As New OleDbCommand(query, db)
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            ' Preenche o DataTable com os dados da consulta
            adapter.Fill(dt)
            ' Limpar colunas existentes para evitar duplicações

            ' Define o DataSource do DataGridView como o DataTable preenchido

            dataGridView.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao processar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Public Function CadastroFuncionario(CPF As String, NomeFunc As String, funcaoF As String, usuarioe As String, senhae As String, dataNasc As Date)
        Try
            ' Verifica se a conexão foi inicializada
            If db Is Nothing Then
                Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'conectar_banco()' primeiro.")
            End If
            ' Abre a conexão se estiver fechada
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If

            ' Insere o Funcionario na tabela funcionario
            Dim queryFuncionario As String = "INSERT INTO tb_Funcionarios (CPF, Nome, Funcao, Usuario, Senha, Data) VALUES (@CPF, @Nome, @Funcao, @Usuario, @Senha, @Data)"
            Using cmdFuncionario As New OleDbCommand(queryFuncionario, db)
                cmdFuncionario.Parameters.AddWithValue("@CPF", CPF)
                cmdFuncionario.Parameters.AddWithValue("@Nome", NomeFunc)
                cmdFuncionario.Parameters.AddWithValue("@Funcao", funcaoF)
                cmdFuncionario.Parameters.AddWithValue("@Usuario", usuarioe)
                cmdFuncionario.Parameters.AddWithValue("@Senha", senhae)
                cmdFuncionario.Parameters.AddWithValue("Data", dataNasc)
                cmdFuncionario.ExecuteNonQuery()
            End Using
            ' Retornar mensagem de sucesso
            Return "Funcionario cadastrado com sucesso."
        Catch ex As Exception
            ' Retornar mensagem de erro
            Return "Erro ao cadastrar funcionario: " & ex.Message
        Finally
            ' Fecha a conexão se estiver aberta
            If db IsNot Nothing AndAlso db.State = ConnectionState.Open Then
                db.Close()
            End If
        End Try
    End Function
    Public Function PuxarFuncionario(CPF As String, txt_nomeFunc As TextBox, txt_FuncaoFunc As TextBox, txt_usuarioFunc As TextBox, txt_senhaFunc As TextBox)
        '' Verifica se a conexão foi inicializada
        If db Is Nothing Then
            Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'ConectarBanco()' primeiro.")
        End If
        ' Abre a conexão se estiver fechada
        If db.State = ConnectionState.Closed Then
            db.Open()
        End If
        ' SQL query para buscar dados com base no ProdutoID
        Dim queryFuncionare As String = "SELECT Nome, Funcao, Usuario, Senha FROM tb_Funcionarios WHERE CPF = @CPF"
        ' Criar um comando
        Using command As New OleDbCommand(queryFuncionare, db)
            ' Adicionar o parâmetro ao comando
            command.Parameters.AddWithValue("CPF", CPF)

            Try
                ' Executar o comando e obter os dados usando OleDbDataReader
                Using reader As OleDbDataReader = command.ExecuteReader()
                    ' Verificar se há dados retornados pela consulta
                    If reader.HasRows Then
                        reader.Read()
                        ' Atribuir os dados aos TextBoxes
                        txt_nomeFunc.Text = reader("Nome").ToString()
                        txt_FuncaoFunc.Text = reader("Funcao").ToString()
                        txt_usuarioFunc.Text = reader("Usuario").ToString()
                        txt_senhaFunc.Text = reader("Senha").ToString()

                    Else
                        MessageBox.Show("CPF não registrado.")
                    End If
                End Using
            Catch ex As Exception
                ' Tratar erros que possam ocorrer
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
        End Using
    End Function
    Public Function DemitirFuncionario(CPF As String)
        If db Is Nothing Then
            Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'ConectarBanco()' primeiro.")
        End If
        ' Abre a conexão se estiver fechada
        If db.State = ConnectionState.Closed Then
            db.Open()
        End If

        Dim query As String = "DELETE FROM tb_Funcionarios WHERE CPF = @CPF"

        Using command As New OleDbCommand(query, db)
            command.Parameters.AddWithValue("@CPF", CPF)

            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Funcionário excluído com sucesso.")
            Else
                MessageBox.Show("Funcionário não encontrado.")
            End If
        End Using
    End Function
    Public Function CarregarFuncionarios(dataGridViewFunc As DataGridView) As Boolean
        Try
            ' Verifica se a conexão foi inicializada
            If db Is Nothing Then
                Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'conectar_banco()' primeiro.")
            End If

            ' Abre a conexão se estiver fechada
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If
            ' Consulta para obter todos os funcionarios
            Dim query As String = "SELECT CPF, Nome, Funcao, Usuario, Senha, Data FROM tb_Funcionarios"

            Dim cmd As New OleDbCommand(query, db)
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            ' Preenche o DataTable com os dados da consulta
            adapter.Fill(dt)
            ' Limpar colunas existentes para evitar duplicações

            ' Define o DataSource do DataGridView como o DataTable preenchido

            dataGridViewFunc.DataSource = dt

            Return True
        Catch ex As Exception
            MsgBox("Erro ao processar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            If db.State = ConnectionState.Open Then
                db.Close()
            End If
            Return False
        End Try
    End Function
    Public Function EditarFuncionario(CPF As String, Nome As String, Funcao As String, Usuario As String, Senha As String, dataNasc As Date) As Boolean
        Try
            ' Verifica se a conexão foi inicializada
            If db Is Nothing Then
                Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'ConectarBanco()' primeiro.")
            End If

            ' Abre a conexão se estiver fechada
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If

            ' Consulta para atualizar os dados do funcionário com base no CPF
            Dim query As String = "UPDATE tb_Funcionarios SET Nome = @Nome, Funcao = @Funcao, Usuario = @Usuario, Senha = @Senha, Data = @Data WHERE CPF = @CPF"

            Using cmd As New OleDbCommand(query, db)
                cmd.Parameters.AddWithValue("@Nome", Nome)
                cmd.Parameters.AddWithValue("@Funcao", Funcao)
                cmd.Parameters.AddWithValue("@Usuario", Usuario)
                cmd.Parameters.AddWithValue("@Senha", Senha)
                cmd.Parameters.AddWithValue("@Data", dataNasc)
                cmd.Parameters.AddWithValue("@CPF", CPF)

                ' Executa o comando
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Dados do funcionário atualizados com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                Else
                    MessageBox.Show("CPF não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao processar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            ' Fechar a conexão se ela estiver aberta
            If db.State = ConnectionState.Open Then
                db.Close()
            End If
        End Try
    End Function
    Public Function esqueceuSenha(CPF As String, txt_UsuarioRecuperado As TextBox, txt_SenhaRecuperada As TextBox)
        Try
            ' Conectar ao banco de dados
            conectar_banco()

            ' Verificar o estado da conexão
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If

            Dim querysenhas As String = "SELECT Usuario AND Senha FROM tb_Funcionarios WHERE CPF = @CPF"

            ' Criar um comando
            Using command As New OleDbCommand(querysenhas, db)

                command.Parameters.AddWithValue("@CPF", CPF)

                Using reader As OleDbDataReader = command.ExecuteReader()

                    If reader.HasRows Then
                        reader.Read()

                        txt_UsuarioRecuperado.Text = reader("Usuario").ToString()
                        txt_SenhaRecuperada.Text = reader("Senha").ToString()
                        Return True
                    Else
                        MessageBox.Show("CPF não registrado.")
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Tratar erros que possam ocorrer
            MessageBox.Show("Ocorreu um erro: " & ex.Message)
            Return False
        Finally
            ' Fechar a conexão se ela estiver aberta
            If db IsNot Nothing AndAlso db.State = ConnectionState.Open Then
                db.Close()
            End If
        End Try
    End Function
    Public Function MandarUsuario(usuario As String, senha As String) As String
        Dim funcao As String = String.Empty
        Dim query As String = "SELECT Funcao FROM tb_Funcionarios WHERE Usuario = @Usuario AND Senha = @Senha"

        Using command As New OleDbCommand(query, db)
            command.Parameters.AddWithValue("@Usuario", usuario)
            command.Parameters.AddWithValue("@Senha", senha)

            db.Open()
            Dim result = command.ExecuteScalar()
            If result IsNot Nothing Then
                funcao = result.ToString()
            End If
            If "Funcao" = "Administrador" Then
                Menu_admin.ShowDialog()
            ElseIf "Funcao" = "funcionario" Then
                Menu_func.ShowDialog
            End If
        End Using
        Return funcao
    End Function

    Public Function EditarProduto(ByVal ProdutoID As Integer, ByVal Nome As String, ByVal Categoria As String, ByVal Quantidade As Integer, ByVal Custo As Decimal, ByVal PrecoVenda As Decimal, caminho As String) As Boolean
        Try
            ' Verifica se a conexão foi inicializada
            If db Is Nothing Then
                Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'ConectarBanco()' primeiro.")
            End If

            ' Abre a conexão se estiver fechada
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If

            ' Consulta para atualizar os dados do produto com base no ID
            Dim query As String = "UPDATE tb_Produtos SET Nome = @Nome, Categoria = @Categoria, Quantidade = @Quantidade, Custo = @Custo, PrecoVenda = @PrecoVenda, caminho = @caminho WHERE código = @ProdutoID"

            Using cmd As New OleDbCommand(query, db)
                cmd.Parameters.AddWithValue("@Nome", Nome)
                cmd.Parameters.AddWithValue("@Categoria", Categoria)
                cmd.Parameters.AddWithValue("@Quantidade", Quantidade)
                cmd.Parameters.AddWithValue("@Custo", Custo)
                cmd.Parameters.AddWithValue("@PrecoVenda", PrecoVenda)
                cmd.Parameters.AddWithValue("@caminho", caminho)
                cmd.Parameters.AddWithValue("@ProdutoID", ProdutoID)


                ' Executa o comando
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Dados do produto atualizados com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                Else
                    MessageBox.Show("ID do produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao processar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            ' Fechar a conexão se ela estiver aberta
            If db.State = ConnectionState.Open Then
                db.Close()
            End If
        End Try
    End Function

    Public Sub ExcluirProduto(ByVal produtoID As Integer)
        Try
            ' Verifica se a conexão foi inicializada
            If db Is Nothing Then
                Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'ConectarBanco()' primeiro.")
            End If

            ' Abre a conexão se estiver fechada
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If

            ' Consulta SQL para excluir o produto com base no ID
            Dim query As String = "DELETE FROM tb_Produtos WHERE Código = @ProdutoID"

            ' Criar um comando parametrizado
            Using command As New OleDbCommand(query, db)
                command.Parameters.AddWithValue("@ProdutoID", produtoID)

                ' Executar o comando
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Produto excluído com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Nenhum produto encontrado para o ID fornecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao processar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Fechar a conexão se ela estiver aberta
            If db.State = ConnectionState.Open Then
                db.Close()
            End If
        End Try
    End Sub
    Public Sub ExcluirFornecedor(ByVal cnpjFornecedor As String)
        Try
            ' Verifica se a conexão foi inicializada
            If db Is Nothing Then
                Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'ConectarBanco()' primeiro.")
            End If

            ' Abre a conexão se estiver fechada
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If

            ' Consulta SQL para excluir o fornecedor com base no CNPJ
            Dim query As String = "DELETE FROM tb_fornecedores WHERE CNPJ = @CNPJFornecedor"

            ' Criar um comando parametrizado
            Using command As New OleDbCommand(query, db)
                command.Parameters.AddWithValue("@CNPJFornecedor", cnpjFornecedor)

                ' Executar o comando
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Fornecedor excluído com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Nenhum fornecedor encontrado para o CNPJ fornecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao processar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Fechar a conexão se ela estiver aberta
            If db.State = ConnectionState.Open Then
                db.Close()
            End If
        End Try
    End Sub
    Public Sub ExcluirPedido(ByVal pedidoID As Integer)
        Try
            ' Verifica se a conexão foi inicializada
            If db Is Nothing Then
                Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'ConectarBanco()' primeiro.")
            End If

            ' Abre a conexão se estiver fechada
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If

            ' Consulta SQL para excluir o pedido com base no ID
            Dim query As String = "DELETE FROM tb_pedidos WHERE Código = @PedidoID"

            ' Criar um comando parametrizado
            Using command As New OleDbCommand(query, db)
                command.Parameters.AddWithValue("@PedidoID", pedidoID)

                ' Executar o comando
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Pedido excluído com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Nenhum pedido encontrado para o ID fornecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao processar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Fechar a conexão se ela estiver aberta
            If db.State = ConnectionState.Open Then
                db.Close()
            End If
        End Try
    End Sub
    Public Function MudarSenha(ByVal Senhas As String, ByVal CPF As String)
        Try
            ' Consulta para atualizar os dados do funcionário com base no CPF
            Dim query As String = "UPDATE tb_Funcionarios SET Senha = @Senha WHERE CPF = @CPF"

            Using cmd As New OleDbCommand(query, db)
                cmd.Parameters.AddWithValue("@Senha", Senhas)
                cmd.Parameters.AddWithValue("@CPF", CPF)

                ' Abrir a conexão se estiver fechada
                If db.State = ConnectionState.Closed Then
                    db.Open()
                End If

                ' Executa o comando
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Senha atualizada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                Else
                    MessageBox.Show("CPF não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End Using
        Catch ex As Exception
            ' Tratar erros que possam ocorrer
            MessageBox.Show("Ocorreu um erro: " & ex.Message)
            Return False
        End Try
    End Function
    Public Function VerificaCPF(ByVal CPF As String)

    End Function
    Public Function SomaTotalProdutos() As Decimal
        Dim totalValorTotal As Decimal = 0

        Try
            ' Verifica se a conexão foi inicializada
            If db Is Nothing Then
                Throw New InvalidOperationException("A conexão com o banco de dados não foi inicializada. Chame 'ConectarBanco()' primeiro.")
            End If

            ' Abre a conexão se estiver fechada
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If

            ' Consulta SQL para obter a soma dos valores na coluna ValorTotal da tabela tb_produtos
            Dim query As String = "SELECT SUM(ValorTotal) AS total_valor FROM tb_produtos"

            ' Criar um comando para executar a consulta
            Using command As New OleDbCommand(query, db)
                ' Executar a consulta e obter o resultado
                Dim resultado As Object = command.ExecuteScalar()

                ' Verificar se o resultado não é nulo e atribuir à variável totalValorTotal
                If resultado IsNot DBNull.Value Then
                    totalValorTotal = Convert.ToDecimal(resultado)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao processar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Fechar a conexão se ela estiver aberta
            If db.State = ConnectionState.Open Then
                db.Close()
            End If
        End Try
        ' Retorna o total da soma dos valores na coluna ValorTotal
        Return totalValorTotal
    End Function
End Module