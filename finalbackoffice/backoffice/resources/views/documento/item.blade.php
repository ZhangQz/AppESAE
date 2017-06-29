@extends('layouts.master')
@section('content')
  <div class="container-fluid">
    
    <div class="container-fluid table-responsive">
     <table class="table table-hover">
       
     
       
       <thead>
          <tr>
            <th><h2>Nome dos cursos que usam o documento</h2></th>
            
          </tr>
       </thead>
       <tbody>
       
       @foreach ($documento->cursos as $curso) 
       <tr>
       <td> <?php echo $curso->nome ;
?></td>
@endforeach
    </tr><br>  </tbody>
    
     </table>
    </div>
   
  </div>
@endsection
