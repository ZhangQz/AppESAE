@extends('layouts.master')
@section('content')
  <div class="container-fluid">
    <h1>Lista de Propinas</h1>
    <p class="lead">Nesta página apresentamos uma lista de utilizadores registadas na BD...</p>
    <br>
    <div class="container-fluid table-responsive">
      <table class="table table-hover">
        <thead>
          <tr>
            <th>Id</th>
            <th>Numero</th>
            <th>Nome</th>
             
               
            
            
          </tr>
        </thead>
        <tbody>
          @foreach($utilizadores as $utilizador)
            <tr>
              <td><?php echo $utilizador->id; ?></td>
              <td><?php echo $utilizador->numero; ?></td>
               <td><?php echo $utilizador->nome; ?></td>
               
             
             
                    
              <!-- coluna de editar veículo -->
              <td>
                <a class="btn btn-default" href="{{ URL::route('utilizador.edit', $utilizador->id) }}"><img src="{{ asset('imagens/edit.png') }}" width="20" height="20"></a>
              </td>

              <!-- coluna de apagar veículo -->
              <td>
                <form action="{{ route('utilizador.destroy', $utilizador->id) }}" method="POST">
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
    <p><a href="{{ URL::route('utilizador.create') }}">Pretende adicionar mais um utilizador?</a></p>
  </div>
@endsection