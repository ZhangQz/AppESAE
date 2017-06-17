@extends('layouts.master')
@section('content')
  <div class="container-fluid">
    <h1>Lista de Documentos</h1>
    <p class="lead">Nesta página apresentamos uma lista de Documentos registadas na BD...</p>
    <br>
    <div class="container-fluid table-responsive">
      <table class="table table-hover">
        <thead>
          <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Categoria</th>
            
            
          </tr>
        </thead>
        <tbody>
          @foreach($documentos as $documento)
            <tr>
              <td><?php echo $documento->id; ?></td>
              <td><?php echo $documento->nome; ?></td>
              <td><?php echo $documento->categoria; ?></td>
             
             
                    
              <!-- coluna de editar veículo -->
              <td>
                <a class="btn btn-default" href="{{ URL::route('documento.edit', $documento->id) }}"><img src="{{ asset('imagens/edit.png') }}" width="20" height="20"></a>
              </td>

              <!-- coluna de apagar veículo -->
              <td>
                <form action="{{ route('documento.destroy', $documento->id) }}" method="POST">
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
    <p><a href="{{ URL::route('documento.create') }}">Pretende adicionar mais uma documento?</a></p>
  </div>
@endsection