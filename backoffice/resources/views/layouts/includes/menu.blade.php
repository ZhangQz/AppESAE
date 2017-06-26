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
      <li><a href="{{ route('user.index') }}">Users</a></li>
    </ul>
    <ul class="nav navbar-nav navbar-right">
        <!-- Authentication Links -->
        @if (Auth::guest())
            <li><a href="{{ route('login') }}">Login</a></li>
            <li><a href="{{ route('register') }}">Register</a></li>
        @else
            <li class="dropdown">
                <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false">
                    {{ Auth::user()->numero }} <span class="caret"></span>
                </a>

                <ul class="dropdown-menu" role="menu">
                    <li>
                        <a href="{{ route('logout') }}"
                            onclick="event.preventDefault();
                                     document.getElementById('logout-form').submit();">
                            Logout
                        </a>

                        <form id="logout-form" action="{{ route('logout') }}" method="POST" style="display: none;">
                            {{ csrf_field() }}
                        </form>
                    </li>
                </ul>
            </li>
        @endif
    </ul>
  </div>

</nav>
