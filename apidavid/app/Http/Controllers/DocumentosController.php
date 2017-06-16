<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Utilizador;
use App\Curso;
use App\Disciplina;
use App\Documento;
use App\Evento;
use App\User;

class DocumentosController extends Controller
{
  function index() {
    $paper = Documento::all();
    return json_encode($paper);
  }

  function show($id) {
    $paper = Documento::find($id);
    return json_encode($paper);
  }

  function listByCourse($id) {
    $paper = Curso::find($id)->docs()->get();
    return json_encode($paper);
  }

}
