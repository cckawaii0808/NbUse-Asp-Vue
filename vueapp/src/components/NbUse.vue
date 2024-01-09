<template>
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <h1 class="text-center">借用表單</h1>
                <div class="alert alert-primary" role="alert">
                    當前使用者 : {{ borrowList[0].borrowStatus === '未歸還' ? borrowList[0].name : '無人借用' }}
                </div>
                排隊人數: {{ WaitPeople}}

                <div class="mb-3">
                    <input type="text" class="form-control" v-model="UserName" placeholder="請輸入姓名" />
                    <button v-if="borrowList[0].borrowStatus === '已歸還'" class="btn btn-primary mt-2" @click="borrow">我要借用</button>
                    <button v-else class="btn btn-dark mt-2" @click="queue">我要排隊</button>
                </div>
            </div>
        </div>
        <br>
        <br>
        <table class="table table-bordered text-center">
            <thead>
                <tr>
                    <th>順序</th>
                    <th>姓名</th>
                    <th>借用時間</th>
                    <th>歸還時間</th>
                    <th>借用狀態</th>
                    <th>操作</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="(borrow, index) in borrowList" :key="index">
                    <td>{{ borrow.sequence }}</td>
                    <td>{{ borrow.name }}</td>
                    <td>{{ borrow.borrowTime }}</td>
                    <td>{{ borrow.returnTime }}</td>
                    <td>{{ borrow.borrowStatus }}</td>
                    <td>
                        <button @click="returnItem(index)" v-if="!borrow.returnTime">歸還</button>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script lang="js">
    import { defineComponent } from 'vue';

    export default defineComponent({
        data() {
            return {
                NowUser: "",
                UserName: "",
                WaitPeople: 0,
                borrowList: [
                    {
                        sequence: 1,
                        name: 'John Doe',
                        borrowTime: '2022-01-01 10:00',
                        returnTime: null,
                        borrowStatus: '未歸還'
                    },
                    {
                        sequence: 2,
                        name: 'Jane Smith',
                        borrowTime: '2022-01-02 09:30',
                        returnTime: null,
                        borrowStatus: '未歸還'
                    },
                    
                ]
            };
        },
        methods: {
            returnItem(index) {
                // 處理歸還按鈕的邏輯，使用當下的時間
                const currentTime = new Date().toLocaleString();
                this.borrowList[index].returnTime = currentTime;
                this.borrowList[index].borrowStatus = '已歸還';
                console.log(currentTime);
            },
            borrow() {
                alert("借用成功");
                if (this.WaitPeople > 0) {
                    this.WaitPeople--;
                }
            },
            queue() {
                this.WaitPeople++;
                alert(`申請成功:目前等候人數: ${this.WaitPeople}`);
            },
        }
    });
</script>
