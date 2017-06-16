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

class PropinasController extends Controller
{
  function index() {
    $money = Propina::all();
    return json_encode($money);
  }

  function show($id) {
    $money = Propina::find($id);
    return json_encode($money);
  }

  function listByCourse($id) {
    $money = Curso::find($id)->money()->get();
    return json_encode($money);
  }

}
