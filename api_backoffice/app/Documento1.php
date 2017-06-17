<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Documento1 extends Model
{
	protected $table = "documentos";
	protected $primaryKey = "id";
	protected $fillable = array("nome", "categoria");
	public $timestamps = true;
	
	public function cursos()
	{
		return $this->belongsToMany('App\Curso1', 'curso_documento')->withTimestamps();
	}
}
