@extends('layouts.master')
@section('content')
  <div class="container-fluid">
    <h1>Lista de Eventos</h1>
    <p class="lead">Nesta página apresentamos uma lista de eventos registadas na BD...</p>
    <br>
    <div class="container-fluid table-responsive">
      <table class="table table-hover">
        <thead>
          <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Tipo</th>
            <th>Local</th>
            
            
            
          </tr>
        </thead>
        <tbody>
          @foreach($eventos as $evento)
            <tr>
              <td><?php echo $evento->id; ?></td>
              <td><?php echo $evento->nome; ?></td>
               <td><?php echo $evento->tipo; ?></td>
               <td><?php echo $evento->local; ?></td>
             
             
                    
              <!-- coluna de editar veículo -->
              <td>
                <a class="btn btn-default" href="{{ URL::route('evento.edit', $evento->id) }}"><img src="{{ asset('imagens/edit.png') }}" width="20" height="20"></a>
              </td>

              <!-- coluna de apagar veículo -->
              <td>
                <form action="{{ route('evento.destroy', $evento->id) }}" method="POST">
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
    <p><a href="{{ URL::route('evento.create') }}">Pretende adicionar mais um evento?</a></p>
  </div>
@endsection