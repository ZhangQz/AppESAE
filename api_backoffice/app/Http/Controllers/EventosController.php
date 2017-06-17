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

class EventosController extends Controller
{
  function index() {
    $events = Evento::all();
    return json_encode($events);
  }

  function show($id) {
    $events = Evento::find($id);
    return json_encode($events);
  }

  function listByCourse($id) {
    $events = Curso::find($id)->events()->get();
    return json_encode($events);
  }

  function listByDisci($id) {
    $events = Disciplina::find($id)->events()->get();
    return json_encode($events);
  }
}
