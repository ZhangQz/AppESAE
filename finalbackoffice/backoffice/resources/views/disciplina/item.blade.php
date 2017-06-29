@extends('layouts.master')
@section('content')
  <div class="container-fluid">
  
    <div class="container-fluid table-responsive">
      <table class="table table-hover">
       
      <table class="table table-hover">
       
     
       
       <thead>
          <tr>
            <th><h2> Eventos relacionados com a disciplina </h2></th>
            
          </tr>
       </thead>
       <tbody>
       
       @foreach ($disciplina->eventos as $evento) 
       <tr>
       <td> <?php echo $evento->nome ;
?></td>
@endforeach
    </tr><br>  </tbody>
    
     </table>
      
      <table class="table table-hover">
       
     
       
       <thead>
          <tr>
            <th><h2>Nome dos cursos com a disciplina</h2></th>
            
          </tr>
       </thead>
       <tbody>
       
       @foreach ($disciplina->cursos as $curso) 
       <tr>
       <td> <?php echo $curso->nome ;
?></td>
@endforeach
    </tr><br>  </tbody>
    
     </table>
      
     
      
        
      </table>
    </div>
      </div>
@endsection
