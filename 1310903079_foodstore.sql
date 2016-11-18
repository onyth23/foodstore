-- phpMyAdmin SQL Dump
-- version 4.0.8
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 03, 2016 at 11:48 AM
-- Server version: 5.6.14-log
-- PHP Version: 5.4.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `1310903079_foodstorei`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE IF NOT EXISTS `customer` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `phone` int(11) NOT NULL,
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`id`, `name`, `password`, `email`, `address`, `phone`) VALUES
(1310903079, 'Gylfi Gulrót', '$2y$10$WsfwzpHVAG7fbQ1pd1869.Mz.LnH3fCwmxgFeqUi61W/ll7pCF/ay', 'gylfisuf@gmail.com', 'Arnarhraun 39', 5554723),
(1903902929, 'Armann', '$2y$10$fOYJzrLnjJ39N/X/lqT/kOI0Z/EXTz3HesAX7DjwuuBQvks6idl7q', 'armannhj@outlook.com', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `history`
--

CREATE TABLE IF NOT EXISTS `history` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `products_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `quantity` int(2) NOT NULL,
  `price` int(8) NOT NULL,
  `date_bought` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `shipping_address` varchar(60) NOT NULL,
  `shipping_phone` varchar(15) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `products_id` (`products_id`),
  KEY `users_id` (`customer_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=53 ;

--
-- Dumping data for table `history`
--

INSERT INTO `history` (`id`, `products_id`, `customer_id`, `quantity`, `price`, `date_bought`, `shipping_address`, `shipping_phone`) VALUES
(49, 26, 1310903079, 1, 2490, '2016-04-26 09:56:38', 'Arnarhraun 39', '5554723'),
(50, 26, 1310903079, 1, 2490, '2016-04-26 10:04:23', 'Arnarhraun 39', '5554723'),
(51, 19, 1310903079, 3, 790, '2016-04-27 12:15:44', 'Arnarhraun 39', '5554723'),
(52, 4, 1310903079, 1, 10990, '2016-04-27 12:31:34', 'Arnarhraun 39', '5554723');

-- --------------------------------------------------------

--
-- Table structure for table `lager`
--

CREATE TABLE IF NOT EXISTS `lager` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `productname` varchar(255) NOT NULL,
  `productprice` int(255) NOT NULL,
  `description` text NOT NULL,
  `quantity` int(255) NOT NULL,
  `lagerType_id` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_lagertypeID` (`lagerType_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=45 ;

--
-- Dumping data for table `lager`
--

INSERT INTO `lager` (`ID`, `productname`, `productprice`, `description`, `quantity`, `lagerType_id`) VALUES
(1, 'WHEY CREAMY COCKTAIL 2275G', 10490, 'Alvöru Hristingur sem hentar alltaf, blanda af mysu, casein og mjólkurproteinum <br>\r\nWHEY CREAMY COCKTAIL er enginn venjulegur proteindrykkur <br> Hann er ljúffengur og gefur mikla \r\nfyllingu sem gerir það að taka prótein á hverjum degi að raunverulegri ánægju <br> Þetta er vandlega samsett uppskrift til að veita heilnæm prótein sem eru full af öllum nauðsynlegustu amínósýrunum <br> Þessi uppskrift er árangur af ströngum smökkunarprófum til að ná fram þessu óviðjafnanlega rjóma bragði <br>\r\n\r\n Hverjir ættu að nota WHEY CREAMY COCKTAIL?\r\n WHEY CREAMY COCKTAIL er alhliða prótein fæðubótarefni ætlað til daglegra nota. Það er sérstaklega mælt með því að fólk sem þarf meira af prótínum vegna mikila æfinga <br>', 10, 101),
(2, '100% Whey Gold Standard 2.270g', 12990, '100% Whey próteinið var valið Besta fæðubótarefnið og Besta próteinið af neytendum árið 2014! Þetta er tíunda árið í röð sem 100% Whey Gold Standard próteinið hlýtur bæði verðlaunin ! ! <br>\r\n\r\nVerðlauna próteinið frá Optimum Nutrition; 100% Whey Gold standard  er stútfullt af hágæða mysupróteini, amínósýrum og inniheldur nú aminogen® sem er nýjasta uppfinning þeirra sem gerir próteinið enn auðmeltanlegra fyrir fólk með mjólkuróþol. <br>\r\n\r\nInniheldur mikið magn af einangruðu mysupróteini\r\n24g af próteini í hverri skeið.\r\nBlandast mjög fljótt og vel í lítið af vatni. <br>\r\nYfir 4 grömm af glútamíni, glútamín tengdum efnum og 5 grömm af BCAA (branch-chained amino acids) í hverri skeið! <br>', 10, 101),
(3, 'SYNTHA-6™ 470g', 3290, '6 mismunandi gerðir af próteinum\r\n\r\nMeal Replacement; Hægt er að nota SYNTHA-6™ hvenær sem er yfir daginn; á milli mála eða í staðin fyrir máltíð <br>\r\n\r\nSYNTHA-6™ inniheldur 6 mismunandi gerðir af próteinum sem meltast yfir mislangan tíma og tryggja próteinflæði í líkamanum í lengri tíma en önnur prótein. Inniheldur einnig ensími sem stuðla að hámarks nýtingu á próteinum og eykur upptöku á aminósýrum.\r\n<br>\r\n\r\nSYNTHA-6™ hentar því vel í morgunmatinn, beint eftir æfingu, í staðinn fyrir máltíð og á kvöldin.', 10, 101),
(4, '100% Whey Protein Professional 2350gr', 10990, '100% Whey Protein Professional er framúrskarandi hágæða últrasigtað mysuprótein (concentrate og isolate). <br> Mysuprótein er vinsælasta próteinið í vöðvabyggingu og hefur hæsta líffræðilega gildið af öllum prótínum. \r\n<br> Það inniheldur mikið af amínósýrum og einstaklega mikið af þremur mikilvægustu amínósýrunum (BCAA; <br> isoleucine, leucine og valine) og inniheldur líka mikið af anabolísku amínósýrunum L-glútamín og arginine.\r\n<br> \r\n\r\n100% Whey Protein Professional hefur um það bil 10% óskaddaðar ónæmisglóbúlín próteinflögur sem efla ónæmiskerfið og <br> mysupróteinið eykur einnig framleiðslu á glutathione sem er kraftmesta náttúrulega andoxunarefnið í líkamanum.\r\n', 9, 101),
(5, 'Stacker 100% Whey (908gr)', 5990, 'Prótein er helsta byggingarefni vöðvanna. Þetta er besta mögulega hreina próteinið á markaðnum og er án sykurs og aspartame og <br> inniheldur enga slæma fitu. Þú færð í hverjum 30 gr skammti 24 gr af próteini og þar á meðal 4 grömm af glútamíní og og 5.4 grömm af BCAA..\r\n<br>\r\n\r\nÍ hverjum skammti eru aðeins 120 kaloríur. Líkaminn breytir próteinum síst í fitu og <br> hentar því að taka þetta prógram fyrir þá sem eru að byggja upp vöðva, fyrir þá sem eru að grenna sig og vilja móta fyrir vöðvum.\r\n', 10, 101),
(6, 'Big Bang 2.0', 8990, 'Big Bang 2.0 er svakalegasta preworkout formúla á öllu landinu og innihelur 53 virk efni. <br> \r\nBig Bang er mjög sterk blanda með flókinni efnasamsetningu sem láta öll 53 efnin hjálpa þér. <br> \r\nBig Bang var sérstaklega búið til þess að hjálpa þér og styðja á æfingum, sérstaklega við mikil átök. <br> \r\nBig Bang inniheldur multi-creatine fléttu með 6 tegundum af kreatíni. <br> Kreatín eykur vöðvamassa, þol og styrk ásamt því að auka frumustækkun og hraða þeim tíma sem líkaminn þarf til að jafna sig á milli æfinga. <br> \r\n', 10, 102),
(7, 'Hell N.O', 7990, 'Rosalegasta Nitric Oxide blanda ALLRA TÍMA. Inniheldur kreatín, beta-alanin og nitric oxide formúlu. <br> \r\nÞessi formúla gefur rosalega orku á æfingum og þér líður eins og þú getir æft endalaust. <br>  HELL N.O eykur blóðflæði \r\nog súrefnisflæði í vöðvunum og vöðvarnir geta nýtt fæðu og prótein betur og þar af leiðandi eykst vöðvamassi og vöðvarnir harna. <br>  \r\nFrá fyrstu æfingu finnur þú mikinn mun. Þú færð meiri "pump" tilfinningu og æðarnar þrútna. Löngu eftir að þú ert búin á æfingu þá ertu ennþá með pump tilfinningu. <br>  \r\nBeta-alanine er amínósýra sem eykur styrk og úthald í vöðvum. Hún kemur líka í veg fyrir mjólkusýru í vöðvunum og afköst á æfingum aukast! Beta-alanine eykur einnig virkni kreatín í vöðvunum! <br>  \r\nÍ HELL N.O eru margar tegundir af kreatíni sem líkaminn getur nýtt á lengri tíma. <br>  Engin þörf er á að hlaða þessari blöndu. Má þar nefna creatine monohydrate (gamla góða kreatínið), creatine ethyl ester (sem líkaminn getur nýtt hraðar) og creatine pyruvate. <br>  \r\nÍ hverjum skammti af HELL N.O færðu 90% af dagskammti (360mg) af magnesíum. Inniheldur einnig alpha lipon acid sem eykur næmni fyrir insúlíni og eykur glýkogen geymslu vöðvanna. Það hámarkar einnig upptöku á kreatíni og beta-alnine Þú færð aukinn styrk, orku og massast hrikalega með HELL N.O! ', 10, 102),
(8, 'S.A.W. 400G 80 SKAMMTAR', 6990, 'Super AGGRESSIVE Workout S.A.W. er gríðaröflug Pre-Workout formúla. <br> \r\nÞessi súper anabolíska blanda eykur stærð vöðva til muna.  <br> \r\nS.A.W eykur flæði súrefnis og næringarefna til vöðva og örvar vöxt, þessi einstaka blanda inniheldur einnig mikið magn af Beta-Alanine og efnum sem örva taugaboðefnakerfin sem auka úthald og orku á æfingum og minnkar mjólkursýrumyndun.  <br>  \r\nS.A.W hjálpar þér að byggja vöðva, styrk og úthald.', 9, 102),
(9, 'Red Faster', 2990, 'REDFASTER er sérþróaður orkudrykkur hlaðinn af vítamínum og steinefnum. <br> \r\n \r\n* Meiri orka <br> \r\n* Meiri styrkur <br> \r\n* Aukið úthald <br> \r\n* Meiri árangur af æfingum  <br> ', 10, 102),
(10, 'Amino Energy 585g', 7990, 'Amino Energy er frábær orkudrykkur sem hægt er að drekka hvenær sem er yfir daginn til að fá auka orku. <br> \r\nTvær skeiðar á morgnanna í staðinn fyrir kaffið til að hressa þig við eða fjórar skeiðar fyrir æfingu til að gera æfinguna ennþá betri !  <br> \r\n', 6, 102),
(11, 'CREATINE XPLODE', 5990, 'A COMBINATION OF 6 ADVANCED FORMS OF CREATINE THAT WILL KNOCK YOU OUT!  <br> \r\n3 EXTRAORDINARILY GREAT FLAVOURS! <br> \r\nNO CHEAP MONOHYDRATES OR CARBOHYDRATES! <br> \r\nAS MANY AS 100 portions IN ONE PACKAGE! <br> ', 8, 103),
(12, 'BASIC CREATINE', 2350, 'Amarok Basic Creatine improves your muscles performance during high intensity activities such as weight training, <br> \r\nrunning and any other aerobic or anaerobic exercise.<br>  Amarok uses only the highest quality, <br> \r\npurest Creatine available, <br>  giving you the ultimate in muscle energy production. <br> ', 10, 103),
(13, '100% creatine monohydrate 1000gr', 4990, 'Creatine monohydrate var fyrsta byltingarkennda fæðubótarefnið í byrjun níunda áratugarins með ótrúlegum árangri. <br> \r\nKreatín sundlaugin í vöðvunum þínum er ábyrg fyrir því að dreyfa fosfat hópum til að búa til orku (ATP), <br>  þar af leiðandi virkar það sem orkubirgðir í frumunum fyrir vöðvaátak (samdrátt). <br>  \r\nAð auki stækkar kreatín vöðvafrumur og það hefur verið sannað í hundruðum rannsókna!  <br> \r\n100% creatine eykur vöðvastærð og vöðvastyrkleika, <br>  bætir árangur í íþróttum (eykur þol og sérstaklega sprengikraft!). <br>  Inniheldur 200 skammta.', 10, 103),
(14, 'CELLMASS 2.0 Kreatín 525g', 7990, 'Snilldar kreatín formúla sem inniheldur <br> kreatín,<br> prótein,<br> glútamín,<br> taurine og<br> aðeins 1g af kolvetnum í hverjum skammti !<br> \r\nHentar bæði stelpum og strákum', 10, 103),
(15, 'Micronized Creatine 634g ', 4490, 'Hver skammtur inniheldur 3 grömm af 99,9% hreinu CreaPure Kreatín Monohydrate. <br> \r\nDuftið er lyktar- og bragðlaust, það blandast mjög vel hvort sem er í vatn, <br>  próteinhristing eða safa og sest ekki í botninn. \r\n', 10, 103),
(16, 'Bleikt lyftingarbelti', 6990, 'Hefðbundið lyftingarbelti fyrir dömurnar.', 10, 201),
(17, 'Svart Lyftingarbelti - Breitt.', 5490, 'Blanda af leðri og gerviefnum. <br> \r\nSterkar og voldugar sylgjur. <br> \r\nPúðar veita stuðning fyrir bak. <br> ', 10, 201),
(18, 'Blátt Kraftlyftingarbelti', 6990, 'Alvöru belti fyrir alvöru kraftlyftingar.', 5, 201),
(19, 'TREC Drykkjarbrúsi 0.7L', 790, '700 ml sports drink bottle for preparing and storing energy and isotonic drinks. <br> \r\nMade of high quality, light and non-toxic materials. <br>  An interesting design and ergonomic shape offering a perfect fit with the majority of bicycle-mounted brackets. <br>  The bottle is leak-tight and comes equipped with a soft, <br> \r\npull-up type mouthpiece allowing the bottle to be used during the workout. <br>  The cap is protected with an additional,\r\ntransparent shield keeping the mouthpiece clean. <br> ', 21, 202),
(20, 'TREC Stál Hristibrúsi', 2490, 'Award winning stainless steel finish. <br> \r\nBest shaker blender in the world. <br> \r\nKeeps your protein shakes ice cold. <br> \r\nBrought to you by TREC NUTRITION. <br> \r\nMesh in cap mixes protein easily. <br> \r\n', 29, 202),
(21, 'Smart Shake Black', 2490, 'One of the most innovative and advanced shakers in the world. <br> \r\nNow with the OLIMP SPORT NUTRITION. <br> \r\nOLIMP Smart Shake BLACK LABEL means incredible practicality and convenience in everyday use. <br> ', 13, 202),
(22, 'Sterkar Grifflur', 6990, 'Alvöru grifflur fyrir alvöru fólk.', 2, 203),
(23, 'Strappar', 1490, 'Venjulegir strappar fyrir aðstoð við grip í réttstöðulyftu.', 4, 203),
(26, 'Vafningar um Úlnlið', 2490, 'Vafningar Um Úlnlið, veitir góðan stuðning.', 4, 203),
(29, 'TREC WEAR - BLACK ON BLACK - PANTS', 11990, 'Original combination of high-quality materials\r\nTwo discreet pockets with zip\r\nStrippers on legs\r\nCotton 280g - ideal for the warmer season\r\nThey designed and made in Poland', 15, 303),
(30, 'TREC WEAR TRECGIRL - LEGGINS BLACK-WHITE-PINK', 9990, '- Perfectly matched to the body\r\n- Flat seams non-irritating skin\r\n- Quick-drying material\r\n- The use of Nano Silver Technology\r\n- Designed and manufactured in Poland', 15, 303),
(31, 'TREC WEAR - TREC GIRL T-SHIRT LEMON', 4990, 'Trendy colors <br> \r\nHigh quality printing <br> \r\nCut suited to feminine silhouette <br> \r\nuniversal application <br> \r\nUncompromising quality <br> \r\nDesigned and manufactured in Poland <br> ', 3, 301),
(32, 'TREC WEAR - TREC GIRL - LEGGINS BLACK-WHITE', 9990, '- Perfectly matched to the body\r\n- Flat seams non-irritating skin\r\n- Quick-drying material\r\n- The use of Nano Silver Technology\r\n- Designed and manufactured in Poland', 15, 303),
(33, 'TREC WEAR TRECGIRL - LEGGINS BLACK-YELLOW', 9990, '- Perfectly matched to the body\r\n- Flat seams non-irritating skin\r\n- Quick-drying material\r\n- The use of Nano Silver Technology\r\n- Designed and manufactured in Poland', 15, 303),
(34, 'TREC WEAR - TREC GIRL - LEGGINS MULTI-COLOR', 9990, '- Perfectly matched to the body\r\n- Flat seams non-irritating skin\r\n- Quick-drying material\r\n- The use of Nano Silver Technology\r\n- Designed and manufactured in Poland', 12, 303),
(36, 'TREC WEAR - TREC GIRL T-SHIRT BLACK', 4990, 'Trendy colors <br> \r\nHigh quality printing <br> \r\nCut suited to feminine silhouette <br> \r\nuniversal application <br> \r\nUncompromising quality <br> \r\nDesigned and manufactured in Poland <br> ', 4, 301),
(37, 'TREC WEAR - BLACK ON BLACK - SWEATSHIRT', 9990, 'Original combination of high-quality materials\r\nTwo discreet pockets with zip\r\nStrippers on legs\r\nCotton 280g - ideal for the warmer season\r\nThey designed and made in Poland', 15, 302),
(38, 'TREC WEAR HOODIE RED', 11990, 'omfortable and offering a good fit\r\nContrasting applications\r\nPerfect finish and high-quality fabric', 15, 302),
(39, 'TREC WEAR HOODIE BLACK', 11990, 'Comfortable and offering a good fit\r\nContrasting applications\r\nPerfect finish and high-quality fabric', 13, 302),
(40, 'TREC WEAR T-SHIRT NO EXCUSES LEMON', 5990, 'Universal application <br> \r\nCut suited to sports figures <br> \r\nUncompromising quality <br> \r\nDesigned and manufactured in Poland <br> ', 12, 301),
(41, 'TREC WEAR HOODIE BLUE', 11990, 'Comfortable and offering a good fit\r\nContrasting applications\r\nPerfect finish and high-quality fabric', 15, 302),
(42, 'TREC WEAR - TALK - TANK TOP - BLUE ', 5990, 'uncompromising quality <br> \r\n100% high quality cotton <br> \r\ncut matched to a sports figure <br> \r\nstylish details <br> \r\ndesigned and made in Poland <br> ', 8, 301),
(43, 'TREC WEAR HOODIE ORANGE', 11990, 'Comfortable and offering a good fit\r\nContrasting applications\r\nPerfect finish and high-quality fabric', 14, 302),
(44, 'GROW BIG - TANK TOP WHITE', 5990, 'Trendy sleeveless shirt <br>\r\nComfortable sporty cut <br>\r\n100% cotton, excellent sweat absorption <br>', 14, 301);

-- --------------------------------------------------------

--
-- Table structure for table `lagertype`
--

CREATE TABLE IF NOT EXISTS `lagertype` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=304 ;

--
-- Dumping data for table `lagertype`
--

INSERT INTO `lagertype` (`id`, `name`) VALUES
(101, 'protein'),
(102, 'pre workout'),
(103, 'creatin'),
(201, 'belti'),
(202, 'brusar'),
(203, 'Vafningar, grifflur og strappar.'),
(301, 'bolir'),
(302, 'peysur'),
(303, 'buxur');

-- --------------------------------------------------------

--
-- Table structure for table `worker`
--

CREATE TABLE IF NOT EXISTS `worker` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `jobtitle` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=12 ;

--
-- Dumping data for table `worker`
--

INSERT INTO `worker` (`ID`, `name`, `username`, `password`, `jobtitle`, `email`) VALUES
(1, 'Ármann Hallbert Jónsson', 'armann29', 'ice123', 'Owner', 'armann29@fitness.is'),
(2, 'Gylfi Þór Helgason', 'Gylfi', '*157A9C874BBD3705FAB29E6430949CA870DA798B', 'Owner', 'gylfisuf@gmail.com'),
(4, 'Sindri Örn Sinni', 'Sinni', 'sinni123', 'Sales', ''),
(6, 'SindriS', 'SindriS', 'ice123', 'Sales', 'sales@icefitness.com'),
(7, 'Svavar', 'Svavar', 'ice123', 'Lager', 'svavar@icefitness.is'),
(10, 'Izzy', 'Izzy29', '*C77DDFA42A2A4558DE3DAD3011E7DE0C84F176BD', 'lager', 'izzy@icefitness.is'),
(11, 'Stebbi', 'stebbi123', 'ice123', 'lager', 'stebbi@icefitness.is');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `history`
--
ALTER TABLE `history`
  ADD CONSTRAINT `history_ibfk_2` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`id`),
  ADD CONSTRAINT `history_ibfk_3` FOREIGN KEY (`products_id`) REFERENCES `lager` (`ID`);

--
-- Constraints for table `lager`
--
ALTER TABLE `lager`
  ADD CONSTRAINT `fk_lagertypeID` FOREIGN KEY (`lagerType_id`) REFERENCES `lagertype` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
