<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Curso extends Model
{
  function alunos() {
    return $this->belongsToMany('App\Utilizador', 'curso_utilizador');
  }

  function unidades() {
    return $this->belongsToMany('App\Disciplina', 'curso_disciplina');
  }

  function docs() {
    return $this->belongsToMany('App\Documento', 'curso_documento');
  }

  function events() {
    return $this->belongsToMany('App\Evento', 'curso_evento');
  }

  function money() {
    return $this->belongsToMany('App\Propina', 'curso_propina');
  }


}
