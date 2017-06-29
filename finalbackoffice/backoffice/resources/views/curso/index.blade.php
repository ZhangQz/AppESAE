@extends('layouts.master')
@section('content')
  <div class="container-fluid">
    <h1>Lista de Cursos</h1>
    <p class="lead">Nesta página apresentamos uma lista de cursos registados na BD...</p>
    <br>
    <div class="container-fluid table-responsive">
      <table class="table table-hover">
        <thead>
          <tr>
            <th>Nome</th>
            <th>Tipo de Curso</th>
            <th>Responsavel</th>
            <th>Descrição</th>
            <th>Email</th>
            <th>ETCS</th>
             <th>Editar</th>
              <th>Relacoes</th>
              <th>Eliminar</th>


          </tr>
        </thead>
        <tbody>
          @foreach($cursos as $curso)
            <tr>
              <td><?php echo $curso->nome; ?></td>
              <td><?php echo $curso->tipodecurso; ?></td>
              <td><?php echo $curso->responsavel; ?></td>
                <td><?php echo $curso->descricao; ?></td>
                  <td><?php echo $curso->email; ?></td>
                    <td><?php echo $curso->ects; ?></td>


              <!-- coluna de editar veículo -->
              <td>
                <a class="btn btn-default" href="{{ URL::route('curso.edit', $curso->id) }}"><img src="{{ asset('imagens/edit.png') }}" width="20" height="20"></a>
              </td>
              <td>
                <a class="btn btn-default" href="{{ URL::route('curso.show', $curso->id) }}"><img src="{{ asset('imagens/edit.png') }}" width="20" height="20"></a>
              </td>


              <!-- coluna de apagar veículo -->
              <td>
                <form action="{{ route('curso.destroy', $curso->id) }}" method="POST">
                  <input type="hidden" name="_token" value="{{ csrf_token() }}">
                  <input type="hidden" name="_method" value="DELETE">
                  <button type="submit" class="btn btn-danger">
                    <img src="{{ asset('imagens/delete.png') }}" width="20" height="20">
                  </button>
                </form>
              </td>
            </tr>
          @endforeach
        </tbody>
      </table>
    </div>
    <p><a href="{{ URL::route('curso.create') }}">Pretende adicionar mais um curso?</a></p>
  </div>
@endsection
