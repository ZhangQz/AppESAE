<?php

namespace App;
use App\Curso1;
use App\Evento1;

use Illuminate\Database\Eloquent\Model;

class Disciplina1 extends Model
{
	protected $table = "disciplinas";
	protected $primaryKey = "id";
	protected $fillable = array("nome");
	public $timestamps = true;

	public function cursos()
	{
		return $this->belongsToMany('App\Curso1', 'curso_disciplina')->withTimestamps();
	}

	public function eventos()
	{
		return $this->belongsToMany('App\Evento1', 'disciplina_evento')->withTimestamps();
	}
}
