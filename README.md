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

### Backend AI

Projekt komunikuje się z modelem AI na backendzie, w tym momencie dostosowany
jest do serwera REST uruchamianego przez
[llama.cpp](https://github.com/ggerganov/llama.cpp) (aplikacja `server`), oraz
testowana była na modelu Mistral-7B i jego derywatywach
([Mistral-RP-0.1-7B-GGUF](https://huggingface.co/Undi95/Mistral-RP-0.1-7B-GGUF?not-for-all-audiences=true)).

Aby uruchomić backend, należy pobrać (skompilować) llama.cpp, pobrać plik modelu
i uruchomić serwer wydając polecenie, na przykład:

```bash
./server -m <plik modelu> -ngl 35 --host 127.0.0.1
```

(tutaj następuje przeniesienie 35 warstw modelu na urządzenie CUDA, wymagana
jest odmiana llama.cpp z obsługą CUDA, w przeciwnym wypadku parametr `-ngl` nie
jest dostępny)

Pełna dokumentacja serwera: <https://github.com/ggerganov/llama.cpp/blob/master/examples/server/README.md>

#### docker

Można też uruchomić Backend AI llama.cpp w oparciu o plik
`docker-compose.llamacpp.yml`. W tym celu należy utworzyć plik `.env`, w którym
znajdą się dwie zmienne definiujące wariant serwera oraz ścieżkę lokalną do
pliku modelu, np.:

```env
LLAMA_VARIANT=full
MODEL_PATH=U:\ml\krakowiak-7b.gguf.q4_k_m.bin
```

Dostępne warianty to: `full` (CPU), `full-cuda` (NVIDIA GPU) i `full-rocm` (AMD
ROCm GPU).

Uruchomienie:

```sh
docker compose -f docker-compose.llamacpp.yml up
```

### Konfiguracja Backendu AI

W pliku `Game.Api/appsettings.json`, możesz zdefiniować ścieżkę do URL serwera
llama.cpp:

```json
"AiEndpoint": {
    "EndpointUrl": "http://127.0.0.1:8080/completion"
}
```

Niezbędne jest również wybranie modułów odpowiedzialnych za komunikację z
backendem AI i przygotowaniem promptów, które to należy wybrać jako pełne nazwy
typów, włącznie z ich _assembly_, dla Mistral-7B należy wybrać
`AlpacaPromptProvider`:

```json
"AiBackendProvider": "Game.Shared.External.Providers.Ai.LlamaCpp.LlamaCppBackendProvider, Game.Shared.External, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
"AiPromptTemplateProvider": "Game.Shared.External.Providers.Ai.AlpacaPromptProvider, Game.Shared.External, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
```

### Formatowanie kodu i commitów

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