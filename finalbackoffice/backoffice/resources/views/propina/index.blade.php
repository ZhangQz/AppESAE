@extends('layouts.master')
@section('content')
  <div class="container-fluid">
    <h1>Lista de Propinas</h1>
    <p class="lead">Nesta página apresentamos uma lista de propinas registadas na BD...</p>
    <br>
    <div class="container-fluid table-responsive">
      <table class="table table-hover">
        <thead>
          <tr>
            <th>Id</th>
            <th>Ano</th>
            <th>M�s</th>
             <th>Valor</th>
              <th>Pago</th>
              <th>Editar</th>
              <th>Relacoes</th>
              <th>Eliminar</th>
               
            
            
          </tr>
        </thead>
        <tbody>
          @foreach($propinas as $propina)
            <tr>
              <td><?php echo $propina->id; ?></td>
              <td><?php echo $propina->ano; ?></td>
               <td><?php echo $propina->mes; ?></td>
               <td><?php echo $propina->valor; ?></td>
               <td><?php echo $propina->pago; ?></td>
             
             
                    
              <!-- coluna de editar veículo -->
              <td>
                <a class="btn btn-default" href="{{ URL::route('propina.edit', $propina->id) }}"><img src="{{ asset('imagens/edit.png') }}" width="20" height="20"></a>
         
              </td>
              
              <td>
                
             <a class="btn btn-default" href="{{ URL::route('propina.show', $propina->id) }}"><img src="{{ asset('imagens/edit.png') }}" width="20" height="20"></a>
              </td>

              <!-- coluna de apagar veículo -->
              <td>
                <form action="{{ route('propina.destroy', $propina->id) }}" method="POST">
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
    <p><a href="{{ URL::route('propina.create') }}">Pretende adicionar mais uma propina?</a></p>
  </div>
@endsection