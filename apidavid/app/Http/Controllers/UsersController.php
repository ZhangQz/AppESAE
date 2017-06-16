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
