-- phpMyAdmin SQL Dump
-- version 2.7.0-pl2
-- http://www.phpmyadmin.net
-- 
-- Servidor: localhost
-- Tempo de Geração: Jun 28, 2014 as 12:20 PM
-- Versão do Servidor: 5.0.18
-- Versão do PHP: 5.1.2
-- 
-- Banco de Dados: `financeiro`
-- 

-- --------------------------------------------------------

-- 
-- Estrutura da tabela `categoria`
-- 

CREATE TABLE `categoria` (
  `codcat` int(11) NOT NULL,
  `descat` varchar(30) NOT NULL,
  `cadastrado` varchar(30) default NULL,
  `modificado` varchar(30) default NULL,
  `cadpor` varchar(30) default NULL,
  PRIMARY KEY  (`codcat`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- 
-- Extraindo dados da tabela `categoria`
-- 

INSERT INTO `categoria` VALUES (1, 'Alimentação', '', '', 'ADMIN');
INSERT INTO `categoria` VALUES (2, 'Compras', '', '', 'ADMIN');
INSERT INTO `categoria` VALUES (3, 'Contas de Água', '', '', 'ADMIN');
INSERT INTO `categoria` VALUES (4, 'Contas de Luz', '', '', 'ADMIN');
INSERT INTO `categoria` VALUES (5, 'Contas de Telefone', '', '', 'ADMIN');
INSERT INTO `categoria` VALUES (6, 'Educação', '', '', 'ADMIN');
INSERT INTO `categoria` VALUES (7, 'Empregados', '', '', 'ADMIN');
INSERT INTO `categoria` VALUES (8, 'Lar', '', '', 'ADMIN');
INSERT INTO `categoria` VALUES (9, 'Lazer', '', '', 'ADMIN');
INSERT INTO `categoria` VALUES (10, 'Salário', '', '', 'ADMIN');
INSERT INTO `categoria` VALUES (11, 'Saúde', '', '', 'ADMIN');

-- --------------------------------------------------------

-- 
-- Estrutura da tabela `login`
-- 

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `senha` varchar(8) NOT NULL,
  `nivel` varchar(15) NOT NULL,
  `cadastrado` varchar(50) default NULL,
  `modificado` varchar(50) default NULL,
  `cadpor` varchar(50) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- 
-- Extraindo dados da tabela `login`
-- 

INSERT INTO `login` VALUES (1, 'ADMIN', 'admin123', 'Administrador', NULL, NULL, NULL);
INSERT INTO `login` VALUES (2, 'ROBERTO', '123', 'Usuário', '28/04/2014 10:34:36', NULL, 'ADMIN');
INSERT INTO `login` VALUES (3, 'JANAINA', 'ja190503', 'Usuário', '29/04/2014 11:24:17', NULL, 'ADMIN');

-- --------------------------------------------------------

-- 
-- Estrutura da tabela `movimentacao`
-- 

CREATE TABLE `movimentacao` (
  `codmov` int(11) NOT NULL,
  `vencimento` varchar(10) NOT NULL,
  `valor` float default NULL,
  `descmov` char(30) NOT NULL,
  `descat` varchar(30) NOT NULL,
  `desubcat` varchar(30) default NULL,
  `tipomov` char(1) NOT NULL,
  `situacao` varchar(9) default NULL,
  `cadastrado` varchar(30) default NULL,
  `modificado` varchar(30) default NULL,
  `cadpor` varchar(30) default NULL,
  PRIMARY KEY  (`codmov`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- 
-- Extraindo dados da tabela `movimentacao`
-- 


-- --------------------------------------------------------

-- 
-- Estrutura da tabela `subcategoria`
-- 

CREATE TABLE `subcategoria` (
  `codsub` int(11) NOT NULL,
  `descat` varchar(30) NOT NULL,
  `desubcat` varchar(50) NOT NULL,
  `cadastrado` varchar(30) default NULL,
  `modificado` varchar(30) default NULL,
  `cadpor` varchar(30) default NULL,
  `codcat` int(11) NOT NULL,
  PRIMARY KEY  (`codsub`),
  KEY `fk_categoria` (`codcat`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- 
-- Extraindo dados da tabela `subcategoria`
-- 

INSERT INTO `subcategoria` VALUES (1, 'Alimentação', 'Bebidas', '18/05/2014 01:12:14', NULL, 'ADMIN', 0);
INSERT INTO `subcategoria` VALUES (2, 'Alimentação', 'Comidas', '18/05/2014 01:12:24', NULL, 'ADMIN', 0);
