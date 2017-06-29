@extends('layouts.master')
@section('content')
  <div class="container-fluid">
    <h1>Cursos com propinas</h1>
    <p class="lead">Nesta página apresentamos uma lista de propinas associadas a cursos registadas na BD...</p>
    <br>
    <div class="container-fluid table-responsive">
      <table class="table table-hover">
        <thead>
          <tr>
            <th>Curso</th>
            <th>Propina</th>
            
               
            
            
          </tr>
        </thead>
        <tbody>
          @foreach($curso_propinas as $curso_propina)
            <tr>
              <td><?php echo $curso_propina->curso_id; ?></td>
              <td><?php echo $curso_propina->propina_id; ?></td>
              
             
             
                    
              <!-- coluna de editar veículo -->
              <td>
                <a class="btn btn-default" href="{{ URL::route('curso_propina.edit', $curso_propina->id) }}"><img src="{{ asset('imagens/edit.png') }}" width="20" height="20"></a>
              </td>

              <!-- coluna de apagar veículo -->
              <td>
                <form action="{{ route('curso_propina.destroy', $curso_propina->id) }}" method="POST">
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
    <p><a href="{{ URL::route('curso_propina.create') }}">Pretende adicionar mais ?</a></p>
  </div>
@endsection