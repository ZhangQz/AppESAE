<nav class="navbar navbar-static-top navbar-default">
  <div class="container-fluid">
    <div class="navbar-header">
      <span class="navbar-brand"><strong>Página de administrador</strong></span>
    </div>
    <ul class="nav navbar-nav">
      <li><a href="{{ route('index') }}">Inicio</a></li>
      <li><a href="{{ route('curso.index') }}">Cursos</a></li>
      <li><a href="{{ route('disciplina.index') }}">Disciplinas</a></li> 
      <li><a href="{{ route('documento.index') }}">Documentos</a></li> 
      <li><a href="{{ route('evento.index') }}">Eventos</a></li>
      <li><a href="{{ route('propina.index') }}">Propinas</a></li>
      <li><a href="{{ route('utilizador.index') }}">Utilizadores</a></li>
      
    </ul>
  </div>
</nav>