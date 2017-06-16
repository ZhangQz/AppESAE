<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Utilizador;
use App\Curso;
use App\Disciplina;
use App\Documento;
use App\Evento;
use App\User;

class UtilizadoresController extends Controller
{
    function index() {
      $users = Utilizador::all();
      return json_encode($users);
    }

    function show($id) {
      $users = Utilizador::find($id);
      return json_encode($users);
    }

    function listByCourse($id) {
      $users = Curso::find($id)->alunos()->get();
      return json_encode($users);
    }
}
