@extends('layouts.master')
@section('content')
  <div class="container-fluid">
    <h1>Lista de Disciplinas</h1>
    <p class="lead">Nesta página apresentamos uma lista de disciplinas registadas na BD...</p>
    <br>
    <div class="container-fluid table-responsive">
      <table class="table table-hover">
        <thead>
          <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Editar</th>
              <th>Relacoes</th>
              <th>Eliminar</th>
            
            
          </tr>
        </thead>
        <tbody>
          @foreach($disciplinas as $disciplina)
            <tr>
              <td><?php echo $disciplina->id; ?></td>
              <td><?php echo $disciplina->nome; ?></td>
             
             
                    
              <!-- coluna de editar veículo -->
              <td>
                <a class="btn btn-default" href="{{ URL::route('disciplina.edit', $disciplina->id) }}"><img src="{{ asset('imagens/edit.png') }}" width="20" height="20"></a>
                
              </td>
              
               <td>
                
                <a class="btn btn-default" href="{{ URL::route('disciplina.show', $disciplina->id) }}"><img src="{{ asset('imagens/edit.png') }}" width="20" height="20"></a>
              </td>

              <!-- coluna de apagar veículo -->
              <td>
                <form action="{{ route('disciplina.destroy', $disciplina->id) }}" method="POST">
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
    <p><a href="{{ URL::route('disciplina.create') }}">Pretende adicionar mais uma disciplina?</a></p>
  </div>
@endsection