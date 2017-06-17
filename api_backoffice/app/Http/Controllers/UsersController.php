<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Utilizador;
use App\Curso;
use App\Disciplina;
use App\Documento;
use App\Evento;
use App\Propina;
use App\User;
use App\Curso1;
use App\Utilizador1;
use App\Disciplina1;
use App\Documento1;
use App\Evento1;
use App\User1;
use App\Propina1;

class UsersController extends Controller
{
  function index() {
    $pessoas = User::all();
    return json_encode($pessoas);
  }

  function show($id) {
    $pessoas = User::find($id);
    return json_encode($pessoas);
  }
}
