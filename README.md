# Game-Api - Koło Naukowe .NET

## Opis
Witaj w repozytorium Koła Naukowego .NET, poświęconym naszemu najnowszemu projektowi gry! Niniejsza gra z gatunku RPG, jest aplikacją internetową, której głównym założeniem jest pełna niepowtarzalność wszelkich przygód w niej.

## O Projekcie
Nasza gra to innowacyjna produkcja, która łączy w sobie zarówno aspekty nowoczesnych wzorców architektonicznych, jak i wykorzystuje pełen potencjał najnowszych technologii.

- Platforma: Gra jest tworzona na platformie .NET, co pozwala nam wykorzystać bogaty ekosystem narzędzi dostępnych w środowisku .NET.
- Rodzaj gry: Nasza gra to przeglądarkowa produkcja z gatunku RPG(Role-Playing Game), która pozwala graczom wcielić się w postać i odgrywać niepowtarzalne przygody.
- Technologie: W trakcie projektu będziemy używać takich technologii jak PostgreSQL, RabbitMQ, OpenAI, aby dostarczyć nowatorskie rozwiązania.
- Architektura: Aplikacja została utworzona jako modularny monolit, z wykorzystaniem popularnych wzorców typu CQRS.
- Cel projektu:  Naszym głównym celem jest stworzenie gry, która nie tylko dostarczy rozrywki, ale także będzie doskonałym przykładem naszych umiejętności w dziedzinie programowania i projektowania.

## Środowisko

Projekt wykorzystuje narzędzie
[git-conventional-commits](https://github.com/qoomon/git-conventional-commits)
do kontroli, czy tytuły commitów zgadzają się ze specyfikacją. A by móc z niego
skorzystać, należy je zainstalować z wykorzystaniem NPM:

```bash
npm install --global git-conventional-commits
```

Narzędzie zostanie aktywowane automatycznie poprzez wykorzystanie
[Husky.Net](https://alirezanet.github.io/Husky.Net/guide/) -- aby skorzystać z
Husky, należy wykonać pierwszy raz komendę `dotnet restore` na projekcie
`Game.Api\Game.Api.csproj` i zostanie automatycznie zainstalowane wraz z innymi
zależnościami.

W podobny sposób, przed każdym commitem, pliki zostaną sprawdzone i
przeformatowane z wykorzystaniem narzędzia [csharpier](https://csharpier.com/) w
celu ujednolicenia stylu pisania kodu.

## Autorzy
Ten projekt jest rozwijany przez członków Koła Naukowego .NET na Politechnice Lubelskiej. 

## Podziękowania
Chcielibyśmy podziękować wszystkim, którzy przyczynili się do tego projektu. Dziękujemy za zainteresowanie naszym projektem i zapraszamy do wspólnego tworzenia wspaniałej gry!