<article class="markdown-body entry-content container-lg" itemprop="text"><h1 dir="auto"><a id="user-content-pinaphoto-aspnet" class="anchor" aria-hidden="true" href="#pinaphoto-aspnet"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>My Company .NET</h1>
<hr>
<h2 dir="auto"><a id="user-content-opis-i-uruchomienie-sieciowe" class="anchor" aria-hidden="true" href="#opis-i-uruchomienie-sieciowe"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a><strong>OPIS I URUCHOMIENIE SIECIOWE</strong></h2>
<p dir="auto">Zawiera domyślnie stworzone konto administratora. <strong>Login - admin / Hasło - superpassword</strong></p>
<hr>
<h2 dir="auto"><a id="user-content-konfiguracja-i-uruchomienie-lokalne" class="anchor" aria-hidden="true" href="#konfiguracja-i-uruchomienie-lokalne"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a><strong>KONFIGURACJA I URUCHOMIENIE LOKALNE</strong></h2>
<ul dir="auto">
<li>Admin: Login - admin / Hasło - superpassword</li>
</ul>
<p dir="auto"><strong>Aby uruchomić aplikację lokalnie trzeba:</strong></p>
<p dir="auto"><strong>1.</strong> W pliku <strong>appsetings.json</strong> należy zmienić <strong>ConnectionString</strong></p>
<ul dir="auto">
<li>DATA SOURCE={Nazwa maszyny};Integrated Security=true;DATABASE={Nazwa bazy};Trusted_Connection=True;MultipleActiveResultSets=True</li>
</ul>
<p dir="auto">Przykład</p>
<ul dir="auto">
<li>DATA SOURCE=DESKTOP-MMS65A0;Integrated Security=true;DATABASE=PinAPhoto; Database=Identity; Trusted_Connection=True;MultipleActiveResultSets=true</li>
</ul>
<p dir="auto"><strong>2.</strong> Utworzyć bazę danych poprzez wpisanie w <strong>konsoli menadżera pakietów</strong></p>
<ul dir="auto">
<li><strong>add-migration nazwamigracji</strong></li>
</ul>
<p dir="auto">Po sukcesie</p>
<ul dir="auto">
<li><strong>update-database -verbose</strong></li>
</ul>
<p dir="auto">Powinno nam to utworzyć lokalną bazę danych z Administratorem</p>
<hr>
</article>
