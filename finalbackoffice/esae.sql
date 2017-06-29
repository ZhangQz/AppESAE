-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 29-Jun-2017 às 17:30
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
  `tipodecurso` enum('pós-graduação','mestrado','livre') NOT NULL DEFAULT 'mestrado',
  `responsavel` text CHARACTER SET utf8mb4,
  `descricao` text CHARACTER SET utf8mb4 NOT NULL,
  `email` varchar(150) NOT NULL,
  `ects` int(11) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cursos`
--

INSERT INTO `cursos` (`id`, `nome`, `tipodecurso`, `responsavel`, `descricao`, `email`, `ects`, `created_at`, `updated_at`) VALUES
(6, 'Gestão de Recursos Humanos e Comportamento Organizacional', 'mestrado', 'Prof. Doutor Paulo Pinto Moreira:Doutor em Ciências Empresariais e Mestre em Gestão de Recursos Humanos, pela Esc. Economia e Gestão da Universidade do Minho, Licenciado em Gestão R.H. e Psicologia do Trabalho. Professor universitário no ensino público e privado nas áreas da gestão, investigador integrado no CEPESE - Centro de Estudos da População, Economia e Sociedade, Univ. Porto. Experiência profissional em funções de direção geral, gestão e assessoria de recursos humanos, consultoria de desenvolvimento organizacional.', 'As temáticas do ciclo de estudos estão ancoradas no mais recente estado da arte da área científica e, de forma simultânea, adequam-se às atuais e concretas necessidades das organizações. Deste modo, pretende-se alinhar as temáticas e respetivas práticas de ensino às atuais exigências do perfil de competências dos técnicos e gestores de recursos humanos que, entre outros aspetos, contemplam uma maior sensibilidade para o negócio, mindset estratégico e global que, aliados a um robusto know-how técnico de recursos humanos e às imprescindíveis soft skills, suscitem uma efetiva contribuição para o valor das organizações.', 'esae@ismt.pt', 120, '2017-06-26 23:00:00', '2017-06-29 14:12:43'),
(7, 'Psicologia Clínica', 'mestrado', 'Professor Doutor Carlos Farate;\r\nProfessora Doutora Joana Sequeira;\r\nProfessora Doutora Marina Cunha', 'No âmbito do 2.º ciclo de formação em Psicologia no Instituto Superior Miguel Torga, conducente ao grau de Mestre de acordo com o novo modelo de organização do ensino superior, foi registada a adequação do Curso de Mestrado em Psicologia Clínica (Nº de Registo - R/B - AD - 54/2007 - DR, 2ª série, nº 28 de 8 de fevereiro de 2007). \r\nO 2º ciclo da formação em Psicologia organiza-se ao longo de dois anos de trabalho de 60 ECTS, cada um, perfazendo um total de 120 ECTS. \r\nO primeiro ano de trabalho é constituído por 12 unidades curriculares (6 por semestre) de 5 ECTS cada. Cada uma destas unidades curriculares deve adotar objetivos, metodologias e avaliações específicas no âmbito da formação proposta para este 2º ciclo. \r\nO segundo ano de formação é composto por um estágio de caráter profissionalizante (30 ECTS) e pela elaboração de uma dissertação final (30 ECTS). \r\nO Mestrado em Psicologia Clínica apresenta três áreas de especialização. ', 'esae@ismt.pt ', 120, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(8, 'Serviço Social', 'mestrado', 'Professora Doutora Alcina Maria de Castro Martins ', 'Após adequação ao processo de Bolonha, a duração do 1º ciclo de estudos em Serviço Social no ISMT, é de sete semestres, 210 ECTS e a do 2º ciclo de estudos em Serviço Social de três semestres, 90 ECTS. Segundo o estipulado nos artigos 9º e 18º do Decreto-Lei nº 74/2006 de 24 de março os dois primeiros ciclos de formação não podem exceder cinco anos, ou seja, 300 ECTS.\r\n\r\nA estrutura curricular está organizada em três semestres, com 10 unidades curriculares (UC), das quais seis são trimestrais, três são semestrais e a orientação científica da dissertação é anual. As UC estão distribuídas pelas seguintes áreas científicas: Serviço Social, área de especialidade do ciclo de estudos com 8 UC, seguindo-se com 1 UC em Ciências Sociais e uma de opção a ser escolhida de entre o elenco das UC das áreas científicas de Ciências Sociais, História, Sociologia ou Psicologia.\r\n\r\nOs Núcleos de Estudos e Investigação (NEI) da área científica de Serviço Social são UC obrigatórias. A abertura e funcionamento de cada um dos Núcleos será definido em cada curso de mestrado, em função do quadro de docentes e do número de mestrandos inscritos, prevendo-se a existência de um mínimo de 6 inscrições para cada NEI. Dos NEI em funcionamento, os estudantes escolhem um. ', 'esae@ismt.pt ', 90, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(9, 'Análise de Redes Sociais e Media Sociais', 'pós-graduação', 'Profª. Doutora Inês Amaral;\r\nProf. Doutor Jaime Silva;', '', 'inesamaral@ismt.pt\r\njaimesilva@ismt.pt', 9, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(10, 'Audiovisuais e Multimédia', 'pós-graduação', 'Profª. Doutora Inês Amaral', 'O curso de Pós-Graduação em Audiovisuais e Multimédia visa a capacitação dos discentes de conhecimentos e competências para a produção e implementação de projetos na área dos Audiovisuais e Multimédia, com particular destaque para Conteúdos Multiplataforma, Vídeo, Documentário e Digital Storytelling.', 'inesamaral@ismt.pt', 30, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(11, 'Literacia Mediática na Era Digital', 'pós-graduação', 'Profª. Doutora Patrícia Silveira', 'O curso de Pós-Graduação em Literacia Mediática na Era Digital aborda questões salientes do campo da literacia para os media no novo ambiente mediático digital, com o principal objetivo de que os discentes sejam capazes de transpor e de adaptar os propósitos e a pedagogia associada à Educação para os Media aos seus contextos profissionais específicos.', 'esae@ismt.pt', 6, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(12, 'Gestão Global e Prática de Organizações Sociais ', 'pós-graduação', 'Susana Henriques', 'As Organizações de Economia Social (OES) representam uma área de crescimento exponencial na economia do país. Economia essa cada vez mais competitiva e exigente, o que conduz a um desafio destas organizações em disporem de condições de eficiência e estratégias de diferenciação de modo a adaptarem-se a uma sociedade em mudança. \r\nA boa gestão das OES, concretizada por profissionais devidamente qualificados é preponderante para garantir o seu valor económico a curto e médio/longo prazo, conciliando sustentabilidade e qualidade. \r\nNeste sentido, esta Pós-Graduação procura dar resposta a estas necessidades, através da qualificação dos dirigentes e técnicos das OES, assente num programa curricular composto por temáticas cruciais no bom desempenho económico e social: Gestão da Qualidade, Gestão Financeira, Legislação Laboral, Empreendedorismo Social e Inovação Social. \r\nDe modo a garantir a implementação operacional, a Pós-Graduação apresenta uma forte componente prática, assegurada por um corpo docente de referência nesta área.', 'cc.ggpos.ismt@gmail.com', 33, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(13, 'Avaliação e Intervenção com Famílias em Risco e Perigo', 'pós-graduação', 'Professora Doutora Joana Sequeira', 'O curso de Pós-Graduação em Avaliação e Intervenção com Famílias em Risco e Perigo destina-se a profissionais que trabalham na área social, da saúde e educação que se relacionam com o sistema de promoção e proteção de crianças e jovens em risco e/ou perigo. Destina-se assim a assistentes sociais, psicólogos, médicos enfermeiros, professores, educadores sociais e outros profissionais que trabalhem com crianças, jovens e famílias na situação de risco e perigo.', 'esae@ismt.pt', 19, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(14, 'Terapias Cognitivo-Comportamentais Contextuais em Perturbações Psicológicas e Problemas de Saúde', 'pós-graduação', 'Professora Doutora Marina Cunha;\r\nProfessora Doutora Ana Galhardo;\r\n', 'O curso de Pós-Graduação em Terapias Cognitivo-Comportamentais Contextuais em Perturbações Psicológicas e Problemas de Saúde destina-se a profissionais na área da psicologia e da saúde, bem como a estudantes finalistas destas áreas científicas.', 'esae@ismt.pt', 21, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(15, 'Acupuntura Estética e Dermatológica', 'pós-graduação', 'Prof. Diogo Amorim', 'Com este curso pretende-se que os profissionais adquiram conhecimentos e competências necessários a uma prática de excelência na área da acupuntura estética e dermatológica.', 'esae@ismt.pt', 22, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(16, 'Neuropsicologia Clínica', 'pós-graduação', 'Helena Espírito Santo', 'O objetivo geral deste curso é fornecer as qualificações clínicas e experiência relevante em Neuropsicologia clínica, ajudando a preparar/alargar a carreira para trabalhar com crianças ou adultos com perturbações neurológicas ou patologias com substrato neurológico (e.g., acidente vascular cerebral, traumatismo craniano, tumores cerebrais, epilepsia, distúrbio de défice de atenção, dislexia, discalculia, autismo, esquizofrenia).', 'esae@ismt.pt', 40, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(17, 'Intervenção com Doentes Alzheimer e Outras Demências', 'pós-graduação', 'Laura Lemos', 'O principal objetivo deste curso é a aquisição de conhecimentos e competências, no âmbito da avaliação e intervenção, que contribuam para a melhoria da prestação de cuidados e bem-estar das pessoas que apresentam quadros demenciais.', 'pg.demencias@gmail.com', 48, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(18, 'Desenvolvimento de Conteúdos Mobile', 'pós-graduação', 'Prof. Doutor Pedro Jerónimo', 'Esta Pós-Graduação visa a capacitação dos discentes de conhecimentos e competências para a utilização de dispositivos móveis (smartphones e tablets) e com eles / para eles produzir e gerir, de forma autónoma, conteúdos multimédia. ', 'pedrojeronimo@ismt.pt', 30, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(19, 'Social Media Marketing e Multimédia', 'pós-graduação', 'Professora Doutora Inês Amaral ', 'O curso de Pós-Graduação em Social Media Marketing e Multimédia visa a capacitação dos discentes de conhecimentos e competências para a utilização dos media sociais e das redes sociais, com recurso a conteúdos multimédia, nos planos de marketing das empresas e das marcas. ', 'inesamaral@ismt.pt', 6, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(20, 'Psicoterapia Breve', 'pós-graduação', 'Prof. Doutor Carlos Augusto Amaral Dias;\r\nMestre Filipe Leão Miranda', 'A Psicoterapia Breve é uma intervenção terapêutica de natureza psicológica, de inspiração psicanalítica, cuja duração é limitada no tempo. Os seus objetivos passam pela procura de uma melhoria da qualidade de vida da pessoa, e de uma mudança na relação consigo própria e com o mundo, escolhendo-se, para tal, um determinado problema mais premente e focando os esforços na sua resolução. Com este curso, e com o envolvimento de um conjunto de profissionais universitários e clínicos com experiência em intervenção terapêutica breve, propõe-se facultar uma sistematização de conhecimentos teóricos e uma sensibilização à prática e técnica da psicoterapia a todos os profissionais interessados e/ou implicados na área do aconselhamento ou apoio psicológico.', 'esae@ismt.pt ', 19, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(21, 'Psicoteraia da Criança e do Adolescente', 'mestrado', 'Prof. Doutor Carlos Augusto Amaral Dias;\r\nMestre Ana Vasconcelos', 'Com este curso pretende-se fornecer aos profissionais os instrumentos conceptuais e técnico-clínicos que lhes permitam uma abordagem terapêutica da criança e do adolescente, levando em linha de conta os problemas próprios ao desenvolvimento, bem como os aspetos psicopatológicos inerentes às falhas desenvolvimentais. Pretende-se assim, fornecer a capacidade de resolução de situações concretas com que os profissionais se poderão deparar no seu dia a dia clínico. ', 'esae@ismt.pt ', 30, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(22, 'Psicoterapia Psicanalítica', 'pós-graduação', 'Prof. Doutor Carlos Augusto Amaral Dias;\r\nProf. Doutor Carlos Manuel da Cruz Farate', 'O curso de pós-graduação em Psicoterapia Psicanalítica visa fornecer conhecimentos sobre os fundamentos conceptuais da psicanálise na sua dimensão teórica e técnica, bem como o aprofundamento da metodologia de intervenção no campo de acção da psicoterapia psicodinâmica. ', 'esae@ismt.pt ', 29, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(23, 'Empreendedorismo Criativo', 'pós-graduação', 'Mestre João Abreu', 'Este curso procurará atingir dois objetivos primordiais da experiência de empreender – SER E SABER EMPREENDER. E como? Sensibilizando os participantes para a importância da comunicação, das redes e das relações interpessoais e das equipas como fatores de competitividade, bem como da definição de estratégias e do uso de ferramentas tradicionais e inovadoras de gestão, para um adequado posicionamento dos negócios no mercado. ', 'esae@ismt.pt ', 43, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(24, 'Gestão das Organizações do Terceiro Setor', 'mestrado', 'Prof. Doutor Miguel Matias ', 'O Terceiro Setor tem hoje uma dimensão e uma importância vital na economia e sociedade portuguesas. Trata-se de um setor constituído por um conjunto muito heterogéneo de organizações de cariz privado, onde se incluem, entre outras, as Fundações, as Associações, os Clubes Desportivos e Recreativos, as Organizações de Cariz Religioso ou Social, as Cooperativas, os Institutos e outras organizações ligadas à Administração Pública. \r\nA área da economia social tem de se profissionalizar para enfrentar os exigentes desafios com que se depara atualmente e que se irão intensificar no futuro. A criação e o desenvolvimento sustentável deste tipo de organizações exige que os seus responsáveis possuam sólida formação sobre o seu enquadramento legal, sobre as inúmeras especificidades associadas à sua gestão e financiamento e sobre a criação de redes ou parcerias entre as próprias organizações, o Estado e o restante tecido empresarial, entre outros temas. ', 'esae@ismt.pt', 28, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(25, 'Diretor de Segurança', 'livre', 'Professor Doutor Pedro Simões', 'Proporcionar aos participantes conhecimentos atualizados sobre os diversos tipos de segurança que fazem parte do currículo do curso.\r\nAprofundar os conhecimentos teóricos e práticos na área da segurança, especialmente na formação específica para o exercício de funções de direção e de gestão de segurança.', ' esae@ismt.pt', 210, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(26, 'Educação para os Media Digitais', 'livre', 'Doutora Patrícia Silveira', 'O curso Curta Duração em Educação para os Media Digitais aborda questões salientes do campo da literacia para os media no novo ambiente mediático digital, com o principal propósito de que os discentes sejam capazes de adaptar a pedagogia associada à Educação para os Media aos seus contextos profissionais específicos.', 'esae@ismt.pt', 20, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(27, 'Psicanálise', 'livre', 'Prof. Doutor Carlos Amaral Dias', 'Fazer a iniciação à psicanálise, como teoria e prática, implica um esforço prévio para “mapear” o pensamento psicanalítico pelas áreas disciplinares - os discursos - e pelos domínios de aplicação – as práticas – que substanciam a “ciência do inconsciente” no quotidiano social do início do segundo milénio.', 'esae@ismt.pt', 45, '2017-06-26 23:00:00', '2017-06-26 23:00:00'),
(28, 'Alta Performance em Vendas', 'livre', 'Miguel Neves Matias', 'No final da formação os formandos deverão ser capazes de colocar em prática técnicas e ferramentas que aumentem a sua produtividade nos processos de venda.', 'esae@ismt.pt', 16, NULL, NULL);

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
(1, 'Disciplina 1', '2017-06-29 14:16:56', '2017-06-29 14:16:56');

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
(2, 'fhdjkshfsd', 'Capas', '2017-06-18 10:22:13', '2017-06-18 10:39:17'),
(3, 'Relatório de Mestrado', 'Capas', '2017-06-29 14:17:10', '2017-06-29 14:17:10'),
(4, 'Fichas', 'Critérios', '2017-06-29 14:17:17', '2017-06-29 14:17:17');

-- --------------------------------------------------------

--
-- Estrutura da tabela `eventos`
--

CREATE TABLE `eventos` (
  `id` int(11) NOT NULL,
  `nome` varchar(150) NOT NULL,
  `tipo` set('workshop','palestra','ronaldo') NOT NULL DEFAULT 'workshop',
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `local` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `eventos`
--

INSERT INTO `eventos` (`id`, `nome`, `tipo`, `created_at`, `updated_at`, `local`) VALUES
(2, 'Leitura na biblioteca', 'workshop', '2017-06-29 14:20:22', '2017-06-29 14:20:22', 'No ismt'),
(3, 'apto', 'workshop', '2017-06-29 14:20:46', '2017-06-29 14:20:46', 'eeee');

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;
--
-- AUTO_INCREMENT for table `disciplinas`
--
ALTER TABLE `disciplinas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `documentos`
--
ALTER TABLE `documentos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `eventos`
--
ALTER TABLE `eventos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
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
