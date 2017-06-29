@extends('layouts.master')
@section('content')
  <div class="container-fluid">

    <div class="container-fluid table-responsive">
      <table class="table table-hover">



       <thead>
          <tr>
            <th><h2>Nome das disciplinas do curso</h2></th>

          </tr>
       </thead>
       <tbody>

       @foreach ($curso->disciplinas as $disciplina)
       <tr>
       <td> <?php echo $disciplina->nome ;
?></td>
@endforeach
    </tr><br>  </tbody>

     </table>



    <table class="table table-hover">

          <thead>
          <tr>
            <th><h2>Nome dos documentos do curso</h2></th>

          </tr>
       </thead>
       <tbody>

       @foreach ($curso->documentos as $documento)
       <tr>
       <td> <?php echo $documento->nome ;
?></td>
@endforeach
    </tr>  </tbody>

     </table>



      <table class="table table-hover">
          <thead>
          <tr>
            <th><h2>Nome dos eventos do curso</h2></th>

          </tr>
       </thead>
       <tbody>

       @foreach ($curso->eventos as $evento)
       <tr>
       <td> <?php echo $evento->nome
;
?><br></td>
@endforeach

    </tr>  </tbody>

      </table>





      <table class="table table-hover">
         <thead>
          <tr>
            <th><h2>Valor das propinas do curso</h2></th>

          </tr>
       </thead>
       <tbody>

       @foreach ($curso->propinas as $propina)
       <tr>
       <td> <?php echo $propina->valor ;
?></td>
@endforeach
    </tr>  </tbody>

       </table>



    <table class="table table-hover">
          <thead>
          <tr>
            <th><h2>Nome dos alunos do curso</h2></th>

          </tr>
       </thead>
       <tbody>

       @foreach ($curso->utilizadores as $utilizador)
       <tr>
       <td> <?php echo $utilizador->nome ;
?></td>
@endforeach
    </tr>  </tbody>

         </table>


@endsection
