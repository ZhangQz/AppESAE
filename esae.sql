-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 06-Jun-2017 às 18:18
-- Versão do servidor: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `esae`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cursos`
--

CREATE TABLE `cursos` (
  `id_curso` int(11) NOT NULL,
  `nome` text NOT NULL,
  `tipodecurso` enum('pós-graduação','mestrado') NOT NULL DEFAULT 'mestrado',
  `responsavel` text CHARACTER SET utf8mb4,
  `descricao` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
  `email` varchar(150) NOT NULL,
  `telefone` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `disciplinas`
--

CREATE TABLE `disciplinas` (
  `id_disciplinas` int(11) NOT NULL,
  `nome` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `documentos`
--

CREATE TABLE `documentos` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `categoria` set('Boletim','Critérios','Capas','Entregas','Estágios','Folha de sumário') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `eventos`
--

CREATE TABLE `eventos` (
  `id_evento` int(11) NOT NULL,
  `nome` varchar(150) NOT NULL,
  `tipo` enum('workshop','palestra','ronaldo') NOT NULL DEFAULT 'workshop'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `numero` int(11) NOT NULL,
  `password` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `propinas`
--

CREATE TABLE `propinas` (
  `id` int(11) NOT NULL,
  `id_curso` int(11) NOT NULL,
  `ano` date NOT NULL,
  `mes` text NOT NULL,
  `valor` int(11) NOT NULL,
  `pago` tinyint(1) NOT NULL,
  `datapag` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `rel_cursos_doc`
--

CREATE TABLE `rel_cursos_doc` (
  `id` int(11) NOT NULL,
  `curso` int(11) NOT NULL,
  `doc` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `rel_cursos_eventos`
--

CREATE TABLE `rel_cursos_eventos` (
  `id` int(11) NOT NULL,
  `id_curso` int(11) NOT NULL,
  `id_evento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `rel_cursos_propinas`
--

CREATE TABLE `rel_cursos_propinas` (
  `id` int(11) NOT NULL,
  `id_curso` int(11) NOT NULL,
  `id_propinas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `rel_curso_disciplinas`
--

CREATE TABLE `rel_curso_disciplinas` (
  `id` int(11) NOT NULL,
  `id_curso` int(11) NOT NULL,
  `id_disciplina` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `rel_disciplinas_eventos`
--

CREATE TABLE `rel_disciplinas_eventos` (
  `id` int(11) NOT NULL,
  `id_disciplina` int(11) NOT NULL,
  `id_evento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `rel_utilizador_cursos`
--

CREATE TABLE `rel_utilizador_cursos` (
  `id` int(11) NOT NULL,
  `id_curso` int(11) NOT NULL,
  `nrutilizador` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `utilizador`
--

CREATE TABLE `utilizador` (
  `numero` int(11) NOT NULL,
  `nome` text NOT NULL,
  `id_curso` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cursos`
--
ALTER TABLE `cursos`
  ADD PRIMARY KEY (`id_curso`);

--
-- Indexes for table `disciplinas`
--
ALTER TABLE `disciplinas`
  ADD PRIMARY KEY (`id_disciplinas`);

--
-- Indexes for table `documentos`
--
ALTER TABLE `documentos`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `eventos`
--
ALTER TABLE `eventos`
  ADD PRIMARY KEY (`id_evento`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`),
  ADD KEY `numero` (`numero`);

--
-- Indexes for table `propinas`
--
ALTER TABLE `propinas`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `rel_cursos_doc`
--
ALTER TABLE `rel_cursos_doc`
  ADD PRIMARY KEY (`id`),
  ADD KEY `curso` (`curso`),
  ADD KEY `doc` (`doc`);

--
-- Indexes for table `rel_cursos_eventos`
--
ALTER TABLE `rel_cursos_eventos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_curso` (`id_curso`),
  ADD KEY `id_evento` (`id_evento`);

--
-- Indexes for table `rel_cursos_propinas`
--
ALTER TABLE `rel_cursos_propinas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_curso` (`id_curso`),
  ADD KEY `id_propinas` (`id_propinas`);

--
-- Indexes for table `rel_curso_disciplinas`
--
ALTER TABLE `rel_curso_disciplinas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_curso` (`id_curso`),
  ADD KEY `id_disciplina` (`id_disciplina`);

--
-- Indexes for table `rel_disciplinas_eventos`
--
ALTER TABLE `rel_disciplinas_eventos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_disciplina` (`id_disciplina`),
  ADD KEY `id_evento` (`id_evento`);

--
-- Indexes for table `rel_utilizador_cursos`
--
ALTER TABLE `rel_utilizador_cursos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_curso` (`id_curso`),
  ADD KEY `nrutilizador` (`nrutilizador`);

--
-- Indexes for table `utilizador`
--
ALTER TABLE `utilizador`
  ADD PRIMARY KEY (`numero`),
  ADD KEY `numero` (`numero`),
  ADD KEY `id_curso` (`id_curso`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cursos`
--
ALTER TABLE `cursos`
  MODIFY `id_curso` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `disciplinas`
--
ALTER TABLE `disciplinas`
  MODIFY `id_disciplinas` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `documentos`
--
ALTER TABLE `documentos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `eventos`
--
ALTER TABLE `eventos`
  MODIFY `id_evento` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `propinas`
--
ALTER TABLE `propinas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `rel_cursos_doc`
--
ALTER TABLE `rel_cursos_doc`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `rel_cursos_eventos`
--
ALTER TABLE `rel_cursos_eventos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `rel_cursos_propinas`
--
ALTER TABLE `rel_cursos_propinas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `rel_curso_disciplinas`
--
ALTER TABLE `rel_curso_disciplinas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `rel_disciplinas_eventos`
--
ALTER TABLE `rel_disciplinas_eventos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `rel_utilizador_cursos`
--
ALTER TABLE `rel_utilizador_cursos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `login`
--
ALTER TABLE `login`
  ADD CONSTRAINT `login_ibfk_1` FOREIGN KEY (`numero`) REFERENCES `utilizador` (`numero`);

--
-- Limitadores para a tabela `rel_cursos_doc`
--
ALTER TABLE `rel_cursos_doc`
  ADD CONSTRAINT `rel_cursos_doc_ibfk_1` FOREIGN KEY (`curso`) REFERENCES `cursos` (`id_curso`),
  ADD CONSTRAINT `rel_cursos_doc_ibfk_2` FOREIGN KEY (`doc`) REFERENCES `documentos` (`id`);

--
-- Limitadores para a tabela `rel_cursos_eventos`
--
ALTER TABLE `rel_cursos_eventos`
  ADD CONSTRAINT `rel_cursos_eventos_ibfk_1` FOREIGN KEY (`id_evento`) REFERENCES `eventos` (`id_evento`),
  ADD CONSTRAINT `rel_cursos_eventos_ibfk_2` FOREIGN KEY (`id_curso`) REFERENCES `cursos` (`id_curso`);

--
-- Limitadores para a tabela `rel_cursos_propinas`
--
ALTER TABLE `rel_cursos_propinas`
  ADD CONSTRAINT `rel_cursos_propinas_ibfk_1` FOREIGN KEY (`id_curso`) REFERENCES `cursos` (`id_curso`),
  ADD CONSTRAINT `rel_cursos_propinas_ibfk_2` FOREIGN KEY (`id_propinas`) REFERENCES `propinas` (`id`);

--
-- Limitadores para a tabela `rel_curso_disciplinas`
--
ALTER TABLE `rel_curso_disciplinas`
  ADD CONSTRAINT `rel_curso_disciplinas_ibfk_1` FOREIGN KEY (`id_curso`) REFERENCES `cursos` (`id_curso`),
  ADD CONSTRAINT `rel_curso_disciplinas_ibfk_2` FOREIGN KEY (`id_disciplina`) REFERENCES `disciplinas` (`id_disciplinas`);

--
-- Limitadores para a tabela `rel_disciplinas_eventos`
--
ALTER TABLE `rel_disciplinas_eventos`
  ADD CONSTRAINT `rel_disciplinas_eventos_ibfk_1` FOREIGN KEY (`id_evento`) REFERENCES `eventos` (`id_evento`),
  ADD CONSTRAINT `rel_disciplinas_eventos_ibfk_2` FOREIGN KEY (`id_disciplina`) REFERENCES `disciplinas` (`id_disciplinas`);

--
-- Limitadores para a tabela `rel_utilizador_cursos`
--
ALTER TABLE `rel_utilizador_cursos`
  ADD CONSTRAINT `rel_utilizador_cursos_ibfk_1` FOREIGN KEY (`id_curso`) REFERENCES `cursos` (`id_curso`),
  ADD CONSTRAINT `rel_utilizador_cursos_ibfk_2` FOREIGN KEY (`nrutilizador`) REFERENCES `utilizador` (`numero`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
