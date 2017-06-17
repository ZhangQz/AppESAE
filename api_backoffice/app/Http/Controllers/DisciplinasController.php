<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Utilizador;
use App\Curso;
use App\Disciplina;
use App\Documento;
use App\Evento;
use App\User;
use App\Propina;

class DisciplinasController extends Controller
{
  function index() {
    $disci = Disciplina::all();
    return json_encode($disci);
  }

  function show($id) {
    $disci = Disciplina::find($id);
    return json_encode($disci);
  }

  function listByCourse($id) {
    $disci = Curso::find($id)->unidades()->get();
    return json_encode($disci);
  }
}
