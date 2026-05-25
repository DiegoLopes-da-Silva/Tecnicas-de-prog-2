-- Ta incompleto, tem mais coisa depois.


<template>
<div>
<h1>Minhas tarefas</h1>
<input v-model="titulo.tarefa" placeholder="Digite o titulo da tarefa">
<textarea v-model = "descricaoTarefa" placeholder = "Digite a descricao da tarefa"></textarea>
<button @click = "adicionarTarefa">Adicionar</button>
<ul>
  <li v-for = "item in tarefas":key = "item.id">{{ item.titulo }} - {{ item.concluida ? "Concluida" : "Aguardando" }}</li>
</ul>
</div>
</template>
<script setup>
import {ref, nMounted} from "vue";
import axios from "axios";
const tarefas = ref([]);
const tituloTarefa = ref('');
const descricaoTarefa = ref('');
const API_URL = "http://localhost:5081/api/tarefas";
</script>