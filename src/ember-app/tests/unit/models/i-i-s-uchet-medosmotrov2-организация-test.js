import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-uchet-medosmotrov2-организация', 'Unit | Model | i-i-s-uchet-medosmotrov2-организация', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-uchet-medosmotrov2-вредн-факт-произ',
    'model:i-i-s-uchet-medosmotrov2-должности',
    'model:i-i-s-uchet-medosmotrov2-инд-напр-медосм',
    'model:i-i-s-uchet-medosmotrov2-класс-вред-факт',
    'model:i-i-s-uchet-medosmotrov2-контингент-сотр',
    'model:i-i-s-uchet-medosmotrov2-организация',
    'model:i-i-s-uchet-medosmotrov2-подразделения',
    'model:i-i-s-uchet-medosmotrov2-приказ-м-з-р',
    'model:i-i-s-uchet-medosmotrov2-сотрудники',
    'model:i-i-s-uchet-medosmotrov2-список-на-медосм',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
