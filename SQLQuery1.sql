-- Criação da tabela login
CREATE TABLE login (
    Id INT IDENTITY(1,1) PRIMARY KEY, -- Chave primária auto-incrementada
    Usuario NVARCHAR(50) NOT NULL,    -- Nome de usuário, obrigatório
    Senha NVARCHAR(255) NOT NULL      -- Senha, obrigatória
);

-- Criação do índice único na coluna Usuario
CREATE UNIQUE INDEX idx_Usuario ON login(Usuario);

INSERT INTO login(Usuario, senha) values ('mokidezia','123fatec');

SELECT * FROM login;