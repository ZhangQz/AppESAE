<?php

namespace App;

use Illuminate\Database\Eloquent\Model;
use App\Curso1;
use App\Disciplina1;

class Evento1 extends Model
{
	protected $table = "eventos";
	protected $primaryKey = "id";
	protected $fillable = array("nome", "tipo","local");
	public $timestamps = true;

	public function cursos()
	{
		return $this->belongsToMany('App\Curso1', 'curso_evento')->withTimestamps();
	}

	public function disciplinas()
	{
		return $this->belongsToMany('App\Disciplinas1', 'disciplina_evento')->withTimestamps();
	}

}
