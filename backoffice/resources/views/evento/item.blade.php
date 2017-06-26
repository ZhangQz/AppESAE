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
            <th>Evento</th>
            <th>Curso</th>
            <th>Disciplina</th>
            
            
            
            
          </tr>
        </thead>
        <tbody>
          @foreach($eventos as $evento)
            <tr>
              <td><?php echo $evento->id; ?></td>
              <td><?php echo $evento->curso; ?></td>
               <td><?php echo $evento->disciplina; ?></td>
             
             
                    
              
            </tr>
          @endforeach
        </tbody>
      </table>
    </div>
    <p><a href="{{ URL::route('evento.create') }}">Pretende adicionar mais um evento?</a></p>
  </div>
@endsection