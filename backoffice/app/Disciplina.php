<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Disciplina extends Model
{
    protected $table = 'disciplinas';

    function events() {
      return $this->belongsToMany('App\Evento', 'disciplina_evento');
    }
}
