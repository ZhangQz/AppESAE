-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 18-Jun-2017 às 14:36
-- Versão do servidor: 10.1.21-MariaDB
-- PHP Version: 5.6.30

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
  `id` int(11) NOT NULL,
  `nome` text NOT NULL,
  `tipodecurso` enum('pós-graduação','mestrado') NOT NULL DEFAULT 'mestrado',
  `responsavel` text CHARACTER SET utf8mb4,
  `descricao` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
  `email` varchar(150) NOT NULL,
  `telefone` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cursos`
--

INSERT INTO `cursos` (`id`, `nome`, `tipodecurso`, `responsavel`, `descricao`, `email`, `telefone`, `created_at`, `updated_at`) VALUES
(2, 'Psicologia Clinica ', 'mestrado', 'Professor Jacaré', 'algo do zoo', 'jacare@jac.com', 910000001, '2017-06-14 23:00:00', '2017-06-14 23:00:00'),
(3, 'Comunicação Social', 'pós-graduação', 'Ines Amaral', 'Um curso para jornalistas e bons comunicadores', 'ines@ines.com', 234546123, '2017-06-14 23:00:00', '2017-06-15 23:00:00'),
(4, 'Curso de tarologia', 'mestrado', 'eu', 'bla bsjkahdksja', 'n@n.com', 23938222, '2017-06-17 14:40:35', '2017-06-17 14:40:35'),
(5, 'hgppp', 'mestrado', 'prof ines', 'okij', 'fff@gmail.com', 888777666, '2017-06-18 10:23:52', '2017-06-18 10:23:52');

-- --------------------------------------------------------

--
-- Estrutura da tabela `curso_disciplina`
--

CREATE TABLE `curso_disciplina` (
  `curso_id` int(11) NOT NULL,
  `disciplina_id` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `curso_documento`
--

CREATE TABLE `curso_documento` (
  `curso_id` int(11) NOT NULL,
  `documento_id` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `curso_evento`
--

CREATE TABLE `curso_evento` (
  `curso_id` int(11) NOT NULL,
  `evento_id` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `curso_propina`
--

CREATE TABLE `curso_propina` (
  `curso_id` int(11) NOT NULL,
  `propina_id` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `curso_utilizador`
--

CREATE TABLE `curso_utilizador` (
  `curso_id` int(11) NOT NULL,
  `utilizador_id` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `disciplinas`
--

CREATE TABLE `disciplinas` (
  `id` int(11) NOT NULL,
  `nome` varchar(150) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `disciplinas`
--

INSERT INTO `disciplinas` (`id`, `nome`, `created_at`, `updated_at`) VALUES
(4, 'math', '2017-06-18 10:39:05', '2017-06-18 10:39:05');

-- --------------------------------------------------------

--
-- Estrutura da tabela `disciplina_evento`
--

CREATE TABLE `disciplina_evento` (
  `disciplina_id` int(11) NOT NULL,
  `evento_id` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `documentos`
--

CREATE TABLE `documentos` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `categoria` set('Boletim','Critérios','Capas','Entregas','Estágios','Folha de sumário') NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `documentos`
--

INSERT INTO `documentos` (`id`, `nome`, `categoria`, `created_at`, `updated_at`) VALUES
(2, 'fhdjkshfsd', 'Capas', '2017-06-18 10:22:13', '2017-06-18 10:39:17');

-- --------------------------------------------------------

--
-- Estrutura da tabela `eventos`
--

CREATE TABLE `eventos` (
  `id` int(11) NOT NULL,
  `nome` varchar(150) NOT NULL,
  `tipo` enum('workshop','palestra','ronaldo') NOT NULL DEFAULT 'workshop',
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `local` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `eventos`
--

INSERT INTO `eventos` (`id`, `nome`, `tipo`, `created_at`, `updated_at`, `local`) VALUES
(1, 'Leitura ao ar livre1', 'workshop', '2017-06-14 23:00:00', '2017-06-18 10:26:09', 'Será no jardim da sereia às 00:00h do dia anterior.');

-- --------------------------------------------------------

--
-- Estrutura da tabela `migrations`
--

CREATE TABLE `migrations` (
  `id` int(10) UNSIGNED NOT NULL,
  `migration` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `password_resets`
--

CREATE TABLE `password_resets` (
  `email` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `token` varchar(191) COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `propinas`
--

CREATE TABLE `propinas` (
  `id` int(11) NOT NULL,
  `ano` int(4) NOT NULL,
  `mes` set('Janeiro','Fevereiro','Março','') NOT NULL,
  `valor` int(11) NOT NULL,
  `pago` tinyint(1) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `propinas`
--

INSERT INTO `propinas` (`id`, `ano`, `mes`, `valor`, `pago`, `created_at`, `updated_at`) VALUES
(2, 1990, 'Março', 254, 0, '2017-06-18 10:40:13', '2017-06-18 10:40:13'),
(3, 190, 'Janeiro', 555, 1, '2017-06-18 10:49:53', '2017-06-18 10:49:53');

-- --------------------------------------------------------

--
-- Estrutura da tabela `users`
--

CREATE TABLE `users` (
  `id` int(10) UNSIGNED NOT NULL,
  `numero` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `remember_token` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `utilizadores`
--

CREATE TABLE `utilizadores` (
  `id` int(11) NOT NULL,
  `numero` int(11) NOT NULL,
  `nome` text NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `utilizadores`
--

INSERT INTO `utilizadores` (`id`, `numero`, `nome`, `created_at`, `updated_at`) VALUES
(1, 123, 'Mario Alberto', '2017-06-14 23:00:00', '2017-06-14 23:00:00'),
(3, 1054866, 'David', '2017-06-14 23:00:00', '2017-06-18 10:40:25'),
(4, 1234, 'Zhang Qinzhe', '2017-06-14 23:00:00', '2017-06-14 23:00:00'),
(5, 75648, 'Marco Silva', '2017-06-14 23:00:00', '2017-06-14 23:00:00'),
(6, 456, 'david', '2017-06-16 21:28:56', '2017-06-16 21:28:56'),
(7, 12333, 'marco', '2017-06-18 10:40:39', '2017-06-18 10:40:39');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cursos`
--
ALTER TABLE `cursos`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `curso_disciplina`
--
ALTER TABLE `curso_disciplina`
  ADD KEY `id_curso` (`curso_id`),
  ADD KEY `id_disciplina` (`disciplina_id`);

--
-- Indexes for table `curso_documento`
--
ALTER TABLE `curso_documento`
  ADD KEY `curso` (`curso_id`),
  ADD KEY `doc` (`documento_id`);

--
-- Indexes for table `curso_evento`
--
ALTER TABLE `curso_evento`
  ADD KEY `id_curso` (`curso_id`),
  ADD KEY `id_evento` (`evento_id`);

--
-- Indexes for table `curso_propina`
--
ALTER TABLE `curso_propina`
  ADD KEY `id_curso` (`curso_id`),
  ADD KEY `id_propinas` (`propina_id`);

--
-- Indexes for table `curso_utilizador`
--
ALTER TABLE `curso_utilizador`
  ADD KEY `id_curso` (`curso_id`),
  ADD KEY `nrutilizador` (`utilizador_id`);

--
-- Indexes for table `disciplinas`
--
ALTER TABLE `disciplinas`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `disciplina_evento`
--
ALTER TABLE `disciplina_evento`
  ADD KEY `id_disciplina` (`disciplina_id`),
  ADD KEY `id_evento` (`evento_id`);

--
-- Indexes for table `documentos`
--
ALTER TABLE `documentos`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `eventos`
--
ALTER TABLE `eventos`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `migrations`
--
ALTER TABLE `migrations`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `password_resets`
--
ALTER TABLE `password_resets`
  ADD KEY `password_resets_email_index` (`email`);

--
-- Indexes for table `propinas`
--
ALTER TABLE `propinas`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `utilizadores`
--
ALTER TABLE `utilizadores`
  ADD PRIMARY KEY (`id`),
  ADD KEY `numero` (`numero`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cursos`
--
ALTER TABLE `cursos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `disciplinas`
--
ALTER TABLE `disciplinas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `documentos`
--
ALTER TABLE `documentos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `eventos`
--
ALTER TABLE `eventos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `propinas`
--
ALTER TABLE `propinas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `utilizadores`
--
ALTER TABLE `utilizadores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `curso_disciplina`
--
ALTER TABLE `curso_disciplina`
  ADD CONSTRAINT `curso_disciplina_ibfk_1` FOREIGN KEY (`curso_id`) REFERENCES `cursos` (`id`),
  ADD CONSTRAINT `curso_disciplina_ibfk_2` FOREIGN KEY (`disciplina_id`) REFERENCES `disciplinas` (`id`);

--
-- Limitadores para a tabela `curso_documento`
--
ALTER TABLE `curso_documento`
  ADD CONSTRAINT `curso_documento_ibfk_1` FOREIGN KEY (`curso_id`) REFERENCES `cursos` (`id`),
  ADD CONSTRAINT `curso_documento_ibfk_2` FOREIGN KEY (`documento_id`) REFERENCES `documentos` (`id`);

--
-- Limitadores para a tabela `curso_evento`
--
ALTER TABLE `curso_evento`
  ADD CONSTRAINT `curso_evento_ibfk_1` FOREIGN KEY (`evento_id`) REFERENCES `eventos` (`id`),
  ADD CONSTRAINT `curso_evento_ibfk_2` FOREIGN KEY (`curso_id`) REFERENCES `cursos` (`id`);

--
-- Limitadores para a tabela `curso_propina`
--
ALTER TABLE `curso_propina`
  ADD CONSTRAINT `curso_propina_ibfk_1` FOREIGN KEY (`curso_id`) REFERENCES `cursos` (`id`),
  ADD CONSTRAINT `curso_propina_ibfk_2` FOREIGN KEY (`propina_id`) REFERENCES `propinas` (`id`);

--
-- Limitadores para a tabela `curso_utilizador`
--
ALTER TABLE `curso_utilizador`
  ADD CONSTRAINT `curso_utilizador_ibfk_1` FOREIGN KEY (`curso_id`) REFERENCES `cursos` (`id`),
  ADD CONSTRAINT `curso_utilizador_ibfk_2` FOREIGN KEY (`utilizador_id`) REFERENCES `utilizadores` (`id`);

--
-- Limitadores para a tabela `disciplina_evento`
--
ALTER TABLE `disciplina_evento`
  ADD CONSTRAINT `disciplina_evento_ibfk_1` FOREIGN KEY (`evento_id`) REFERENCES `eventos` (`id`),
  ADD CONSTRAINT `disciplina_evento_ibfk_2` FOREIGN KEY (`disciplina_id`) REFERENCES `disciplinas` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
