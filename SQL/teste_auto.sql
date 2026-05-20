USE teste_auto;

-- Stergem intrebarile demo existente si reconstruim corect
DELETE FROM teste_intrebari;
DELETE FROM raspunsuri;
DELETE FROM intrebari;
ALTER TABLE intrebari AUTO_INCREMENT = 1;
ALTER TABLE raspunsuri AUTO_INCREMENT = 1;

-- ============================================================
-- CATEGORIA 1: INDICATOARE RUTIERE (20 intrebari)
-- ============================================================

INSERT INTO intrebari (text_intrebare, id_categorie) VALUES
('Ce semnifică indicatorul cu triunghi roșu și semnul de exclamare?', 1),
('Ce semnifică indicatorul cu triunghi roșu și imaginea unui copil?', 1),
('Ce semnifică indicatorul circular cu fond roșu și bara albă orizontală?', 1),
('Ce semnifică indicatorul circular cu cifra 50 pe fond alb și chenar roșu?', 1),
('Ce semnifică indicatorul octogonal roșu cu inscripția STOP?', 1),
('Ce semnifică indicatorul cu triunghi roșu și imaginea unui semafor?', 1),
('Ce semnifică indicatorul circular cu săgeată albă pe fond albastru?', 1),
('Ce semnifică indicatorul cu triunghi roșu și imaginea unei locomotive?', 1),
('Ce semnifică indicatorul romb galben cu bordură albă?', 1),
('Ce semnifică indicatorul cu triunghi roșu și două săgeți care se încrucișează?', 1),
('Ce semnifică indicatorul circular cu cifra 30 pe fond alb și chenar roșu?', 1),
('Ce semnifică indicatorul cu triunghi roșu și imaginea unui om care lucrează?', 1),
('Ce semnifică indicatorul cu panoul dreptunghiular albastru cu litera P?', 1),
('Ce semnifică indicatorul cu triunghi roșu și imaginea unui drum alunecos?', 1),
('Ce semnifică indicatorul circular cu bicicleta tăiată cu o bară roșie?', 1),
('Ce semnifică indicatorul cu triunghi roșu și imaginea unor pietriș?', 1),
('Ce semnifică indicatorul cu săgeată albă îndreptată în sus pe fond albastru?', 1),
('Ce semnifică indicatorul dreptunghiular verde cu o săgeată și un număr de km?', 1),
('Ce semnifică indicatorul cu triunghi roșu și imaginea unui vânt lateral?', 1),
('Ce semnifică indicatorul circular cu E și cifra 80 pe fond verde?', 1);

-- Raspunsuri categoria 1
INSERT INTO raspunsuri (id_intrebare, text_raspuns, este_corect) VALUES
-- Intrebarea 1
(1, 'Pericol nedefinit', 1),
(1, 'Oprire obligatorie', 0),
(1, 'Drum cu prioritate', 0),
-- Intrebarea 2
(2, 'Zona frecventata de copii, atenție sporită', 1),
(2, 'Școală la distanță de 500 m', 0),
(2, 'Copiii au prioritate absolută', 0),
-- Intrebarea 3
(3, 'Depășirea interzisă', 1),
(3, 'Intrarea interzisă', 0),
(3, 'Accesul interzis tuturor vehiculelor', 0),
-- Intrebarea 4
(4, 'Viteza maximă admisă este de 50 km/h', 1),
(4, 'Viteza minimă obligatorie este de 50 km/h', 0),
(4, 'Limita de viteză a expirat', 0),
-- Intrebarea 5
(5, 'Oprire obligatorie, acordați prioritate', 1),
(5, 'Staționare interzisă', 0),
(5, 'Cedați trecerea', 0),
-- Intrebarea 6
(6, 'Atenție, semafor în apropriere', 1),
(6, 'Semaforul este defect', 0),
(6, 'Dirijarea circulației de către un agent', 0),
-- Intrebarea 7
(7, 'Direcție obligatorie de mers indicată de săgeată', 1),
(7, 'Recomandare de direcție', 0),
(7, 'Sens unic facultativ', 0),
-- Intrebarea 8
(8, 'Trecere la nivel cu calea ferată cu bariere', 1),
(8, 'Stație de tren în apropiere', 0),
(8, 'Calea ferată este prioritară', 0),
-- Intrebarea 9
(9, 'Drum cu prioritate', 1),
(9, 'Atenție la drum', 0),
(9, 'Drum național', 0),
-- Intrebarea 10
(10, 'Intersecție cu drum fără prioritate', 1),
(10, 'Drum cu sens unic', 0),
(10, 'Bifurcație periculoasă', 0),
-- Intrebarea 11
(11, 'Viteza maximă admisă este de 30 km/h', 1),
(11, 'Zonă de oprire la 30 m', 0),
(11, 'Viteza minimă este 30 km/h', 0),
-- Intrebarea 12
(12, 'Lucrări pe carosabil, atenție sporită', 1),
(12, 'Muncitori traversează drumul', 0),
(12, 'Zona de construcții, acces interzis', 0),
-- Intrebarea 13
(13, 'Parcare permisă', 1),
(13, 'Parcare interzisă', 0),
(13, 'Parcare cu plată obligatorie', 0),
-- Intrebarea 14
(14, 'Drum alunecos, reduceți viteza', 1),
(14, 'Drum în reparație', 0),
(14, 'Pericol de îngheț', 0),
-- Intrebarea 15
(15, 'Accesul bicicliștilor interzis', 1),
(15, 'Pistă obligatorie pentru biciclete', 0),
(15, 'Bicicliștii au prioritate', 0),
-- Intrebarea 16
(16, 'Pericol de împrăștiere a pietrișului', 1),
(16, 'Drum cu pietriș, mergeți încet', 0),
(16, 'Carosabil deteriorat', 0),
-- Intrebarea 17
(17, 'Circulație obligatorie înainte', 1),
(17, 'Recomandare de a merge înainte', 0),
(17, 'Drumul continuă drept', 0),
-- Intrebarea 18
(18, 'Indicator de orientare spre o localitate sau destinație', 1),
(18, 'Limita de viteză pe autostradă', 0),
(18, 'Distanța până la ieșirea din autostradă', 0),
-- Intrebarea 19
(19, 'Pericol de vânt lateral puternic', 1),
(19, 'Zona expusă la furtuni', 0),
(19, 'Reducerea vitezei din cauza vântului', 0),
-- Intrebarea 20
(20, 'Limita de viteză pe autostradă este de 80 km/h', 1),
(20, 'Exit numărul 80 de pe autostradă', 0),
(20, 'Distanța până la autostradă este de 80 km', 0);

-- ============================================================
-- CATEGORIA 2: REGULI DE CIRCULATIE (25 intrebari)
-- ============================================================

INSERT INTO intrebari (text_intrebare, id_categorie) VALUES
('Care este viteza maximă admisă în localitate pentru autoturisme?', 2),
('La ce distanță față de o trecere pentru pietoni este interzisă oprirea?', 2),
('Cum trebuie să acționați când semnalul unui agent de circulație contrazice semaforul?', 2),
('Care este obligația conducătorului auto când întâlnește un autovehicul prioritar cu semnale acustice și luminoase active?', 2),
('La ce distanță minimă față de vehiculul din față trebuie menținută?', 2),
('Când este obligatorie utilizarea centurii de siguranță?', 2),
('Care este concentrația maximă de alcool în sânge permisă conducătorilor auto în România?', 2),
('Cum se acordă prioritatea la intersecțiile fără indicatoare?', 2),
('Care este comportamentul corect la trecerea la nivel cu calea ferată fără bariere?', 2),
('Când este permisă depășirea pe dreapta?', 2),
('Care este distanța minimă de vizibilitate necesară pentru a efectua o depășire?', 2),
('La ce distanță față de o intersecție este interzisă oprirea?', 2),
('Ce obligații are conducătorul care deschide portiera vehiculului?', 2),
('Care este viteza maximă admisă pe drumurile naționale în afara localităților?', 2),
('Când este obligatorie aprinderea luminilor de întâlnire?', 2),
('Ce trebuie să faceți când luminile semaforului sunt stinse?', 2),
('Care este comportamentul corect la întâlnirea cu un convoi militar?', 2),
('La ce vârstă minimă se poate obține permis de conducere categoria B?', 2),
('Ce acțiune trebuie să întreprindeți când anvelope pneului față drept se dezumflă brusc?', 2),
('Cum procedați la traversarea unui pod îngust cu sens unic alternativ?', 2),
('Care este semnificația liniei continue duble pe axul drumului?', 2),
('Când este permisă circulația pe banda de urgență a autostrăzii?', 2),
('Ce distanță minimă trebuie menținută față de bicicliști la depășire?', 2),
('Care este viteza maximă admisă pe autostradă pentru autoturisme?', 2),
('Ce trebuie să faceți când frânele nu mai răspund eficient?', 2);

-- Raspunsuri categoria 2
INSERT INTO raspunsuri (id_intrebare, text_raspuns, este_corect) VALUES
-- Intrebarea 21
(21, '50 km/h', 1),
(21, '60 km/h', 0),
(21, '70 km/h', 0),
-- Intrebarea 22
(22, '10 metri', 1),
(22, '5 metri', 0),
(22, '15 metri', 0),
-- Intrebarea 23
(23, 'Se respectă indicațiile agentului de circulație', 1),
(23, 'Se respectă semaforul', 0),
(23, 'Se oprește și se așteaptă', 0),
-- Intrebarea 24
(24, 'Se trage cât mai mult la dreapta și se oprește, dacă este necesar', 1),
(24, 'Se grăbește pentru a elibera drumul', 0),
(24, 'Se continuă deplasarea normal', 0),
-- Intrebarea 25
(25, 'Distanță suficientă pentru a evita coliziunea în cazul frânării bruște', 1),
(25, 'Minim 50 de metri indiferent de viteză', 0),
(25, 'Minim 2 lungimi de vehicul', 0),
-- Intrebarea 26
(26, 'În permanență, atât în localitate cât și în afara acesteia', 1),
(26, 'Doar pe autostradă și drumuri naționale', 0),
(26, 'Doar în afara localităților', 0),
-- Intrebarea 27
(27, '0 g/l - alcoolemia zero este obligatorie', 1),
(27, '0,5 g/l', 0),
(27, '0,8 g/l', 0),
-- Intrebarea 28
(28, 'Vehiculul care vine din dreapta are prioritate', 1),
(28, 'Vehiculul care vine din stânga are prioritate', 0),
(28, 'Cel care a ajuns primul are prioritate', 0),
-- Intrebarea 29
(29, 'Se oprește, se verifică dacă nu vine trenul și se traversează rapid', 1),
(29, 'Se reduce viteza și se traversează fără oprire', 0),
(29, 'Se claxonează și se traversează', 0),
-- Intrebarea 30
(30, 'Când vehiculul din față semnalizează că va vira la stânga', 1),
(30, 'Niciodată nu este permisă depășirea pe dreapta', 0),
(30, 'Întotdeauna, dacă există spațiu suficient', 0),
-- Intrebarea 31
(31, 'Suficientă pentru a efectua manevra în siguranță', 1),
(31, 'Minim 100 de metri', 0),
(31, 'Minim 200 de metri', 0),
-- Intrebarea 32
(32, '5 metri', 1),
(32, '10 metri', 0),
(32, '3 metri', 0),
-- Intrebarea 33
(33, 'Se asigură că nu pune în pericol alți participanți la trafic', 1),
(33, 'Deschide portiera rapid și iese din vehicul', 0),
(33, 'Semnalizează cu mâna înainte de a deschide portiera', 0),
-- Intrebarea 34
(34, '90 km/h', 1),
(34, '100 km/h', 0),
(34, '110 km/h', 0),
-- Intrebarea 35
(35, 'De la lăsarea serii și ori de câte ori vizibilitatea este redusă', 1),
(35, 'Doar noaptea, între orele 22:00 și 06:00', 0),
(35, 'Numai în tunele și pasaje subterane', 0),
-- Intrebarea 36
(36, 'Se procedează ca la o intersecție fără semafor, cu prioritate la dreapta', 1),
(36, 'Semaforul stins înseamnă că se poate circula liber', 0),
(36, 'Se oprește și se așteaptă repararea semaforului', 0),
-- Intrebarea 37
(37, 'Nu se depășește convoi și se menține distanța corespunzătoare', 1),
(37, 'Se depășește convoi pe stânga cu semnalizare', 0),
(37, 'Se depășește pe dreapta, pe acostament', 0),
-- Intrebarea 38
(38, '18 ani', 1),
(38, '16 ani', 0),
(38, '17 ani', 0),
-- Intrebarea 39
(39, 'Se ține ferm volanul și se frânează treptat, trăgând la dreapta', 1),
(39, 'Se frânează brusc și se oprește imediat', 0),
(39, 'Se accelerează pentru a menține controlul', 0),
-- Intrebarea 40
(40, 'Se acordă prioritate vehiculelor care vin din sens opus', 1),
(40, 'Cel care urcă are prioritate', 0),
(40, 'Cel care coboară are prioritate', 0),
-- Intrebarea 41
(41, 'Interzice depășirea și traversarea marcajului pentru toate vehiculele', 1),
(41, 'Permite depășirea cu viteză redusă', 0),
(41, 'Separă benzile de circulație în același sens', 0),
-- Intrebarea 42
(42, 'Niciodată, banda de urgență este rezervată exclusiv vehiculelor de urgență', 1),
(42, 'Când traficul este blocat', 0),
(42, 'Când se circulă cu viteză redusă', 0),
-- Intrebarea 43
(43, 'Minim 1,5 metri', 1),
(43, 'Minim 0,5 metri', 0),
(43, 'Minim 1 metru', 0),
-- Intrebarea 44
(44, '130 km/h', 1),
(44, '140 km/h', 0),
(44, '120 km/h', 0),
-- Intrebarea 45
(45, 'Se trece la treapta inferioară și se folosește frâna de motor', 1),
(45, 'Se oprește imediat pe acostament', 0),
(45, 'Se trage frâna de mână', 0);

-- ============================================================
-- CATEGORIA 3: MANEVRE (20 intrebari)
-- ============================================================

INSERT INTO intrebari (text_intrebare, id_categorie) VALUES
('Cum se efectuează corect o depășire?', 3),
('Când este interzisă efectuarea întoarcerii?', 3),
('Cum se semnalizează intenția de a vira la dreapta?', 3),
('La ce distanță față de intersecție trebuie semnalizată intenția de virare?', 3),
('Ce acțiuni sunt necesare înainte de a porni de pe loc?', 3),
('Cum se efectuează corect manevra de mers înapoi?', 3),
('Când este permisă manevra de întoarcere?', 3),
('Cum trebuie efectuată frânarea pe carosabil umed?', 3),
('Ce reprezintă distanța de oprire a unui vehicul?', 3),
('Cum se efectuează corect manevra de parcare în unghi?', 3),
('Ce obligație are conducătorul care dorește să schimbe banda de circulație?', 3),
('Cum se comportă corect la virarea la stânga pe o stradă cu sens unic?', 3),
('Ce acțiune este interzisă în timpul efectuării depășirii?', 3),
('Cum se reintegrează în circulație după depășire?', 3),
('Ce trebuie verificat înainte de a deschide portiera?', 3),
('Cum se realizează oprirea de urgență pe autostradă?', 3),
('Când este obligatorie semnalizarea la schimbarea direcției?', 3),
('Cum se efectuează corect ieșirea dintr-o parcare?', 3),
('Ce distanță de semnalizare este necesară înainte de o manevră pe autostradă?', 3),
('Cum se efectuează manevra de depășire a unui vehicul care staționează?', 3);

-- Raspunsuri categoria 3
INSERT INTO raspunsuri (id_intrebare, text_raspuns, este_corect) VALUES
-- Intrebarea 46
(46, 'Semnalizare, oglindă, unghi mort, revenire pe banda proprie după depășire', 1),
(46, 'Accelerare rapidă și revenire imediată', 0),
(46, 'Claxonare și depășire rapidă', 0),
-- Intrebarea 47
(47, 'La intersecții, în curbe, pe poduri, în tunele și unde vizibilitatea este redusă', 1),
(47, 'Numai pe autostradă', 0),
(47, 'Niciodată nu este interzisă dacă există spațiu', 0),
-- Intrebarea 48
(48, 'Se acționează semnalizatorul drept cu cel puțin 30 de metri înainte', 1),
(48, 'Se semnalizează prin gesturi cu mâna dreapta', 0),
(48, 'Se claxonează și se virează', 0),
-- Intrebarea 49
(49, 'Minim 50 de metri înainte de intersecție', 1),
(49, 'Chiar la intrarea în intersecție', 0),
(49, 'La minim 10 metri înainte', 0),
-- Intrebarea 50
(50, 'Verificare oglinzi, semnalizare, verificare unghi mort, pornire lentă', 1),
(50, 'Pornire rapidă și semnalizare ulterioară', 0),
(50, 'Claxonare și pornire', 0),
-- Intrebarea 51
(51, 'Lent, cu atenție sporită, verificând în permanență în jur', 1),
(51, 'Rapid, pentru a elibera locul cât mai repede', 0),
(51, 'Cu geamul deschis și cu ajutorul unui pasager', 0),
-- Intrebarea 52
(52, 'Când există suficient spațiu și vizibilitate, fără a periclita alți participanți', 1),
(52, 'Numai în localități', 0),
(52, 'Numai pe drumuri cu două benzi', 0),
-- Intrebarea 53
(53, 'Progresiv, fără frânări bruște, cu pompe ușoare pe pedala de frână', 1),
(53, 'Frânare bruscă pentru a opri cât mai repede', 0),
(53, 'Frânare cu frâna de mână', 0),
-- Intrebarea 54
(54, 'Distanța de reacție plus distanța de frânare', 1),
(54, 'Numai distanța de frânare', 0),
(54, 'Distanța parcursă în 2 secunde', 0),
-- Intrebarea 55
(55, 'Se intră în parcare cu fața sau cu spatele, conform marcajelor, fără a periclita pe alții', 1),
(55, 'Întotdeauna cu spatele pentru siguranță', 0),
(55, 'Întotdeauna cu fața', 0),
-- Intrebarea 56
(56, 'Se asigură că banda vizată este liberă și se semnalizează intenția', 1),
(56, 'Se schimbă rapid banda fără semnalizare', 0),
(56, 'Se claxonează și se schimbă banda', 0),
-- Intrebarea 57
(57, 'Se virează din banda cea mai din stânga disponibilă', 1),
(57, 'Se virează din orice bandă', 0),
(57, 'Nu este permisă virarea la stânga pe sens unic', 0),
-- Intrebarea 58
(58, 'Semnalizarea în exces sau accelerarea bruscă', 1),
(58, 'Verificarea oglinzilor', 0),
(58, 'Menținerea vitezei constante', 0),
-- Intrebarea 59
(59, 'Se revine pe banda proprie doar când vehiculul depășit se vede în oglinda retrovizoare', 1),
(59, 'Se revine imediat după depășire', 0),
(59, 'Se menține pe banda de depășire', 0),
-- Intrebarea 60
(60, 'Dacă există spațiu suficient și nu pune în pericol alți participanți la trafic', 1),
(60, 'Se deschide portiera rapid', 0),
(60, 'Se semnalizează cu luminile de avarie', 0),
-- Intrebarea 61
(61, 'Se semnalizează, se reduce viteza și se oprește pe banda de urgență', 1),
(61, 'Se oprește pe banda de rulare cu luminile de avarie', 0),
(61, 'Se continuă până la prima ieșire', 0),
-- Intrebarea 62
(62, 'Înainte de orice schimbare de direcție sau bandă', 1),
(62, 'Numai pe drumuri cu mai multe benzi', 0),
(62, 'Numai când există alți participanți la trafic în jur', 0),
-- Intrebarea 63
(63, 'Se asigură că nu există pericol, se semnalizează și se iese lent în trafic', 1),
(63, 'Se iese rapid în trafic', 0),
(63, 'Se claxonează și se iese', 0),
-- Intrebarea 64
(64, 'Minim 200 de metri înainte de efectuarea manevrei', 1),
(64, 'Minim 50 de metri', 0),
(64, 'Chiar înainte de manevră', 0),
-- Intrebarea 65
(65, 'Se verifică dacă nu vine nimeni și se efectuează depășirea cu atenție', 1),
(65, 'Se semnalizează și se depășește rapid', 0),
(65, 'Se claxonează și se trece pe trotuar', 0);

-- ============================================================
-- CATEGORIA 4: SITUATII DE URGENTA (20 intrebari)
-- ============================================================

INSERT INTO intrebari (text_intrebare, id_categorie) VALUES
('Ce trebuie să faceți imediat după un accident în care există victime?', 4),
('Cum se procedează când un vehicul ia foc în timpul mersului?', 4),
('Ce acțiuni se întreprind la locul unui accident rutier cu victime?', 4),
('Când este obligatorie montarea triunghiului reflectorizant?', 4),
('Cum se acordă primul ajutor unui rănit inconștient care respiră?', 4),
('Ce se face dacă un pieton este lovit de vehiculul dumneavoastră?', 4),
('Cum se procedează când se observă fum în habitaclu?', 4),
('Ce verificări se fac la un rănit înainte de acordarea primului ajutor?', 4),
('Cum se acționează în cazul unui pneu explodat la viteză mare?', 4),
('Ce se face când frâna de serviciu cedează complet?', 4),
('Cum se acordă primul ajutor în caz de hemoragie externă gravă?', 4),
('Ce obligații are conducătorul implicat într-un accident cu pagube materiale?', 4),
('Cum se comportă la locul unui accident pentru a nu agrava situația?', 4),
('Ce echipament de urgență este obligatoriu în orice autovehicul?', 4),
('Cum se acordă primul ajutor în caz de stop cardiac?', 4),
('Ce se face dacă vehiculul intră în derapaj pe carosabil alunecos?', 4),
('Cum se evacuează un rănit prins în vehicul după accident?', 4),
('Ce se face când farurile nu mai funcționează pe timp de noapte?', 4),
('Cum se procedează dacă se depistează o avarie la direcție în mers?', 4),
('Ce se face în caz de orbire de la farurile unui vehicul din sens opus?', 4);

-- Raspunsuri categoria 4
INSERT INTO raspunsuri (id_intrebare, text_raspuns, este_corect) VALUES
-- Intrebarea 66
(66, 'Se oprește, se asigură locul, se apelează 112 și se acordă primul ajutor', 1),
(66, 'Se continuă drumul și se anunță la destinație', 0),
(66, 'Se mișcă victimele din calea traficului', 0),
-- Intrebarea 67
(67, 'Se oprește imediat, se stinge motorul și se evacuează toți pasagerii', 1),
(67, 'Se accelerează pentru a ajunge la stația de pompieri', 0),
(67, 'Se încearcă stingerea focului cu apă', 0),
-- Intrebarea 68
(68, 'Asigurarea locului, anunțarea serviciilor de urgență și acordarea primului ajutor', 1),
(68, 'Mutarea victimelor pe trotuar', 0),
(68, 'Fotograierea accidentului și plecarea', 0),
-- Intrebarea 69
(69, 'Ori de câte ori vehiculul este imobilizat pe carosabil sau în locuri periculoase', 1),
(69, 'Numai noaptea', 0),
(69, 'Numai pe autostradă', 0),
-- Intrebarea 70
(70, 'Se pune în poziție laterală de siguranță și se supraveghează respirația', 1),
(70, 'Se ridică și se așează pe scaun', 0),
(70, 'Se dă apă să bea', 0),
-- Intrebarea 71
(71, 'Se oprește, se apelează 112 și se acordă primul ajutor', 1),
(71, 'Se lasă pietonul pe loc și se continuă drumul', 0),
(71, 'Se anunță doar victima și se pleacă', 0),
-- Intrebarea 72
(72, 'Se oprește imediat, se stinge motorul și se evacuează vehiculul', 1),
(72, 'Se deschid geamurile și se continuă', 0),
(72, 'Se utilizează extinctorul din mers', 0),
-- Intrebarea 73
(73, 'Conștiența, respirația și pulsul', 1),
(73, 'Dacă are acte de identitate', 0),
(73, 'Dacă poate vorbi și merge', 0),
-- Intrebarea 74
(74, 'Se menține ferm volanul, fără frânare bruscă, cu decelerare treptată', 1),
(74, 'Se frânează brusc și se trage pe dreapta', 0),
(74, 'Se accelerează pentru a menține direcția', 0),
-- Intrebarea 75
(75, 'Se folosește frâna de motor și frâna de mână cu atenție', 1),
(75, 'Se sare din vehicul', 0),
(75, 'Se lasă vehiculul să se oprească singur', 0),
-- Intrebarea 76
(76, 'Se aplică presiune directă pe rană cu material curat', 1),
(76, 'Se îndepărtează corpurile străine din rană', 0),
(76, 'Se pune gheață pe rană', 0),
-- Intrebarea 77
(77, 'Se opresc ambele vehicule, se schimbă datele și se completează formularul de accident', 1),
(77, 'Se pleacă dacă pagubele sunt mici', 0),
(77, 'Se anunță doar asigurătorul', 0),
-- Intrebarea 78
(78, 'Nu se mișcă victimele, se asigură locul și se așteaptă serviciile de urgență', 1),
(78, 'Se mișcă toate victimele pe trotuar', 0),
(78, 'Se încearcă repararea vehiculelor', 0),
-- Intrebarea 79
(79, 'Triunghi reflectorizant, trusă medicală, extinctor și vestă reflectorizantă', 1),
(79, 'Numai triunghiul reflectorizant', 0),
(79, 'Numai trusa medicală', 0),
-- Intrebarea 80
(80, 'Resuscitare cardiopulmonară - 30 compresii toracice și 2 respirații artificiale', 1),
(80, 'Se dă apă și se supraveghează', 0),
(80, 'Se pune în poziție laterală de siguranță', 0),
-- Intrebarea 81
(81, 'Nu se frânează brusc, se menține direcția și se reduce viteza treptat', 1),
(81, 'Se frânează brusc și se trage spre margine', 0),
(81, 'Se accelerează pentru a ieși din derapaj', 0),
-- Intrebarea 82
(82, 'Numai dacă există suspiciunea de leziuni ale coloanei vertebrale, altfel se evacuează', 1),
(82, 'Se lasă în vehicul până vine ambulanța', 0),
(82, 'Se evacuează rapid indiferent de situație', 0),
-- Intrebarea 83
(83, 'Se oprește imediat și se continuă cu luminile de avarie sau se cheamă asistență', 1),
(83, 'Se continuă cu viteză redusă', 0),
(83, 'Se circulă pe acostament', 0),
-- Intrebarea 84
(84, 'Se reduce viteza treptat și se oprește în siguranță cât mai repede posibil', 1),
(84, 'Se continuă cu atenție sporită', 0),
(84, 'Se accelerează pentru a ajunge la service', 0),
-- Intrebarea 85
(85, 'Se reduce viteza, se privește spre marginea drumului și se evită privirea directă în faruri', 1),
(85, 'Se claxonează și se accelerează', 0),
(85, 'Se oprește imediat pe carosabil', 0);

-- ============================================================
-- CATEGORIA 5: LEGISLATIE (15 intrebari)
-- ============================================================

INSERT INTO intrebari (text_intrebare, id_categorie) VALUES
('Ce sancțiune riscați dacă conduceți sub influența alcoolului?', 5),
('Câte puncte de penalizare se acordă pentru depășirea limitei de viteză cu peste 50 km/h?', 5),
('Care este termenul de valabilitate al permisului de conducere categoria B?', 5),
('Ce documente trebuie să aibă conducătorul auto asupra sa?', 5),
('Care este sancțiunea pentru conducerea fără permis?', 5),
('În ce condiții poate fi suspendat permisul de conducere?', 5),
('Ce obligații are conducătorul față de pietoni la trecerea pentru pietoni?', 5),
('Care este amenda minimă pentru neacordarea de prioritate pietonilor?', 5),
('Ce se întâmplă dacă un conducător auto acumulează 15 puncte de penalizare?', 5),
('Care este perioada de probă pentru conducătorii auto nou-licențiați?', 5),
('Ce reprezintă RCA și de ce este obligatoriu?', 5),
('Care este comportamentul legal față de un polițist care face semn de oprire?', 5),
('Ce obligații are conducătorul față de pasageri?', 5),
('Care este amenda pentru utilizarea telefonului mobil în timpul conducerii?', 5),
('Ce se face dacă ITP-ul vehiculului a expirat?', 5);

-- Raspunsuri categoria 5
INSERT INTO raspunsuri (id_intrebare, text_raspuns, este_corect) VALUES
-- Intrebarea 86
(86, 'Reținerea permisului, amendă și răspundere penală dacă alcoolemia depășește limita legală', 1),
(86, 'Numai avertisment la prima abatere', 0),
(86, 'Amendă și continuarea drumului', 0),
-- Intrebarea 87
(87, '6 puncte de penalizare', 1),
(87, '3 puncte de penalizare', 0),
(87, '4 puncte de penalizare', 0),
-- Intrebarea 88
(88, '10 ani', 1),
(88, '5 ani', 0),
(88, 'Pe viață, fără reînnoire', 0),
-- Intrebarea 89
(89, 'Permis de conducere, certificat de înmatriculare, asigurare RCA valabilă și ITP valabil', 1),
(89, 'Numai permisul de conducere', 0),
(89, 'Permis și buletin de identitate', 0),
-- Intrebarea 90
(90, 'Amendă contravențională și răspundere penală', 1),
(90, 'Numai amendă', 0),
(90, 'Reținerea vehiculului', 0),
-- Intrebarea 91
(91, 'La acumularea unui anumit număr de puncte de penalizare sau prin hotărâre judecătorească', 1),
(91, 'Numai prin hotărâre judecătorească', 0),
(91, 'Numai la cererea conducătorului', 0),
-- Intrebarea 92
(92, 'Se oprește și se cedează trecerea pietonilor angajați în traversare', 1),
(92, 'Se claxonează și se continuă dacă pietonii sunt departe', 0),
(92, 'Se reduce viteza fără a opri', 0),
-- Intrebarea 93
(93, 'Amenda este stabilită conform legislației în vigoare și poate ajunge la sute de lei', 1),
(93, 'Nu există amendă, ci numai avertisment', 0),
(93, 'Amenda este fixă, de 200 lei', 0),
-- Intrebarea 94
(94, 'Permisul se suspendă și conducătorul trebuie să susțină un nou examen', 1),
(94, 'Se anulează permisul definitiv', 0),
(94, 'Se acordă o perioadă de grație de 30 de zile', 0),
-- Intrebarea 95
(95, '2 ani de la obținerea permisului', 1),
(95, '1 an de la obținerea permisului', 0),
(95, 'Nu există perioadă de probă', 0),
-- Intrebarea 96
(96, 'Asigurarea obligatorie de răspundere civilă auto, obligatorie pentru toate vehiculele', 1),
(96, 'Asigurare facultativă pentru daune proprii', 0),
(96, 'Asigurare de viață pentru conducători', 0),
-- Intrebarea 97
(97, 'Se oprește imediat la semnul polițistului', 1),
(97, 'Se continuă dacă semaforul este verde', 0),
(97, 'Se reduce viteza și se continuă', 0),
-- Intrebarea 98
(98, 'Se asigură că pasagerii poartă centura de siguranță și că minorii sunt în scaune adecvate', 1),
(98, 'Nu are nicio obligație față de pasageri', 0),
(98, 'Răspunde numai dacă este implicat în accident', 0),
-- Intrebarea 99
(99, 'Amenda contravențională conform legislației, plus puncte de penalizare', 1),
(99, 'Numai avertisment verbal', 0),
(99, 'Confiscarea telefonului', 0),
-- Intrebarea 100
(100, 'Vehiculul nu poate circula pe drumurile publice până la efectuarea ITP-ului', 1),
(100, 'Se poate circula cu amendă', 0),
(100, 'Se poate circula dacă vehiculul este în stare bună', 0);

SELECT 'Intrebarile au fost inserate cu succes!' as rezultat;
SELECT COUNT(*) as total_intrebari FROM intrebari;
SELECT COUNT(*) as total_raspunsuri FROM raspunsuri;
