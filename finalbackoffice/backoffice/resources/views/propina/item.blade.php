@extends('layouts.master')
@section('content')
  <div class="container-fluid">
 
    <div class="container-fluid table-responsive">
      <table class="table table-hover">
        
        <tbody>
           
       <table class="table table-hover">
       
     
       
       <thead>
          <tr>
            <th><h2>Nome das cursos com a propina</h2></th>
            
          </tr>
       </thead>
       <tbody>
       
       @foreach ($propina->cursos as $curso) 
       <tr>
       <td> <?php echo $curso->nome ;
?></td>
@endforeach
    </tr><br>  </tbody>
    
     </table>
      
    
           
                    
              
            </tr>
         
        </tbody>
      </table>
    </div>
    
  </div>
@endsection