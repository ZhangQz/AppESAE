@extends('layouts.master')
@section('content')
  <div class="container-fluid">
    <h1>Lista de Users</h1>
    <p class="lead">Nesta página apresentamos uma lista de users registadas na BD...</p>
    <br>
    <div class="container-fluid table-responsive">
      <table class="table table-hover">
        <thead>
          <tr>
            <th>Id</th>
            <th>Numero</th>
            <th>Password</th>

          </tr>
        </thead>
        <tbody>
          @foreach($users as $user)
            <tr>
              <td><?php echo $user->id; ?></td>
              <td><?php echo $user->numero; ?></td>
               <td><?php echo $user->password; ?></td>




              <!-- coluna de editar veículo -->
              <td>
                <a class="btn btn-default" href="{{ URL::route('user.edit', $user->id) }}"><img src="{{ asset('imagens/edit.png') }}" width="20" height="20"></a>
              </td>

              <!-- coluna de apagar veículo -->
              <td>
                <form action="{{ route('user.destroy', $user->id) }}" method="POST">
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
    <p><a href="{{ URL::route('user.create') }}">Pretende adicionar mais um user?</a></p>
  </div>
@endsection
